using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{
    public Transform lookAtTarget;
    public Transform projectilePrefab;
    public float damp = 0.6f;
    public int shotInterval = 5;

    public void Awake()
    {
        StartCoroutine(Tick());
    }

    public void Update()
    {
        if (lookAtTarget)
        {
            Debug.DrawLine(lookAtTarget.position, transform.position, Color.yellow);
    Vector3 lookPos = lookAtTarget.position - transform.position;
   lookPos.y = 0;
            Quaternion rotate = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime * damp);
        }
    }



    IEnumerator Tick()
    {
        while (true)
        {
            yield return new WaitForSeconds(shotInterval);
            if (projectilePrefab)
            {
                Transform projectile = Instantiate(projectilePrefab, transform.Find("gunShootSpawn").transform.position, Quaternion.identity);
                projectile.gameObject.tag = "projectile";
                projectile.transform.rotation = Quaternion.LookRotation(transform.forward, transform.up);
                projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            }
        }
    }
}