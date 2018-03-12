using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

	public Text timerText;
	public Text playButtonText;

	private bool running;
	private float timerTime;

	// Use this for initialization
	void Start () {
		timerTime = 0.0f;
		running = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (running) {
			timerTime += Time.deltaTime;
		}
		timerText.text = FormatTime (timerTime);
	}

	public void ResetTimer() {
		timerTime = 0.0f;
	}

	public void ToggleTimer() {
		running = !running;
		if (running) {
			playButtonText.text = "Pause";
		} else {
			playButtonText.text = "Start";
		}
	}

	string FormatTime (float time){
		int intTime = (int)time;
		int minutes = intTime / 60;
		int seconds = intTime % 60;
		float fraction = time * 1000;
		fraction = (fraction % 1000);
		string timeText = String.Format ("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
		return timeText;
	}
}
