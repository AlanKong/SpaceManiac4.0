﻿using UnityEngine;
using System.Collections;

public class BattleMineralTextScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BattleScript.battleBegin == false) {
			
			guiText.enabled = false;
		}
		/*if (BattleScript.battleBegin == true) {
			
			if(GameControlScript.currentPlayer == 1)
			{
				guiText.text = GameControlScript.enemyMineral.ToString ();
				guiText.color = Color.red;
			}
			if(GameControlScript.currentPlayer == 2)
			{
				guiText.text = GameControlScript.playerMineral.ToString ();
				guiText.color = Color.green;
			}
			
			
			guiText.enabled = true;
		}*/
	
	}
}
