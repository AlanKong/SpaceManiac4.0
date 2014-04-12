﻿using UnityEngine;
using System.Collections;

public class MoneyDisplayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControlScript.currentScene == 0) {
			guiText.text = (GameControlScript.playerMoney.ToString ()) + "(+" + (GameControlScript.playerMoneyAdd.ToString ()) + ")";
			guiText.color = Color.green;
			guiText.enabled = true;
		} 
		
		if(GameControlScript.currentScene == 1 && GameControlScript.currentPlayer == 1) {
			guiText.text = (GameControlScript.playerMoney.ToString ()) + "(+" + (GameControlScript.playerMoneyAdd.ToString ()) + ")";
			guiText.color = Color.green;
			guiText.enabled = true;
		}
		
		if(GameControlScript.currentScene == 2 && GameControlScript.currentPlayer == 2) {
			guiText.text = (GameControlScript.enemyMoney.ToString ()) + "(+" + (GameControlScript.enemyMoneyAdd.ToString ()) + ")";
			guiText.color = Color.red;
			guiText.enabled = true;
		}

		if(GameControlScript.currentScene == 3) {
			guiText.enabled = false;
		}
		


	}
}
