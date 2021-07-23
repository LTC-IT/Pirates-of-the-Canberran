using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshPathFindingAgent : MonoBehaviour {
    public GameObject target;
    NavMeshAgent m_agent;
    // Use this for initialization
    void Start () {
        m_agent = GetComponent<NavMeshAgent>();

    }
	
	// Update is called once per frame
	void Update () {
        //m_agent.destination = target.transform.position;
    }
}
