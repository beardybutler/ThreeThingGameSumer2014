using System;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
	public float timeLeft = 50.0f;
	bool hasWon = false;
	public void Update()
	{
		timeLeft -= Time.deltaTime;
		GameObject sd = GameObject.Find ("ScrewDriverPickup");
		if (sd == null && timeLeft > 0f) {
			guiText.text = "You are winner!";
			hasWon = true;
			Application.Quit();
				}
		if (timeLeft <= 0.0f && !hasWon)
		{
			// End the level here.

			guiText.text = "You ran out of time";
			Application.Quit();

		}
		else if (!hasWon)
		{
			guiText.text = "Time left = " + (int)timeLeft + " seconds";
		}
		
	}
	
}
