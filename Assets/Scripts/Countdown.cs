using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

	public int allowedTime = 10;
	private Text textField;
	private int currentTime;

	void Awake () {
		currentTime = allowedTime;
		textField = GetComponent<Text>();
		UpdateTimerText();	
		StartCoroutine(Tick());
	}
	
	// Update the GUI
	void UpdateTimerText() {
		textField.text = currentTime.ToString();
	}

	IEnumerator Tick() {
		Debug.Log(currentTime);
		while (currentTime > 0) {
			yield return new WaitForSeconds(1);
			currentTime--;
			UpdateTimerText();
	}
	yield return new WaitForSeconds(3);
	SceneManager.LoadScene(0);
	}
}


