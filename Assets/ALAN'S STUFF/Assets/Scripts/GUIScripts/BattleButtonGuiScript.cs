using UnityEngine;
using System.Collections;

public class BattleButtonGuiScript : MonoBehaviour
{

		public int signalSent;
		public bool disable = false;
		public Texture nonHighlight;
		public Texture highlight;
		public Texture cooling;
		public int MPcost;
		public int moneyCost;
		public int mineralCost;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (BattleScript.battleBegin == false) {

			
						guiTexture.enabled = false;
				}
				if (BattleScript.battleBegin == true) {

						guiTexture.enabled = true;
				}




		if (disable == false) {
			
			if (signalSent == 1 && (Input.GetKeyDown("1") || Input.GetKeyDown("7"))) {
				if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (2f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (2f));
				}
			}
			
			
			if (signalSent == 2 && (Input.GetKeyDown ("2") || Input.GetKeyDown("8"))) {
				if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (1f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (1f));
				}
			}
			
			
			if (signalSent == 3 && (Input.GetKeyDown ("3") || Input.GetKeyDown("9"))) {
				if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (3f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (3f));
				}
			}
			
			
			if (signalSent == 4 && (Input.GetKeyDown ("4") || Input.GetKeyDown("0"))) {
				if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (3f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (3f));
				}
			}
			
			
			if (signalSent == 5 && (Input.GetKeyDown ("5") || Input.GetKeyDown(KeyCode.Minus))) {
				if (GameControlScript.currentPlayer == 1 && 
				    GameControlScript.enemyMineral >= mineralCost &&
				    GameControlScript.enemyMoney >= moneyCost &&
				    GameControlScript.enemyMP >= MPcost) {
					
					GameControlScript.enemyMineral -= mineralCost;
					GameControlScript.enemyMoney -= moneyCost;
					GameControlScript.enemyMP -= MPcost;
					StartCoroutine (clicked (6f));
				}
				if (GameControlScript.currentPlayer == 2 && 
				    GameControlScript.playerMineral >= mineralCost &&
				    GameControlScript.playerMoney >= moneyCost &&
				    GameControlScript.playerMP >= MPcost) {
					
					GameControlScript.playerMineral -= mineralCost;
					GameControlScript.playerMoney -= moneyCost;
					GameControlScript.playerMP -= MPcost;
					StartCoroutine (clicked (6f));
				}
			}

			if (signalSent == 6 && (Input.GetKeyDown ("6") || Input.GetKeyDown(KeyCode.Equals))) {
				LevelController.levelTimerStat = 0f;
			}
			
			
		}







	
		}

		void OnMouseEnter ()
		{
				if (disable == false) {
						guiTexture.texture = highlight;
						DefPriceScript.signalGet = signalSent;
				}
		}
	
		void OnMouseExit ()
		{
				if (disable == false) {
						guiTexture.texture = nonHighlight;
						DefPriceScript.signalGet = 0;
				}
		}

		void OnMouseDown ()
		{
				if (disable == false) {

			if (signalSent == 1) {
								if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
										
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (2f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (2f));
								}
						}
						

			if (signalSent == 2) {
								if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (1f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (1f));
								}
						}
						

			if (signalSent == 3) {
								if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (3f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (3f));
								}
						}
						

			if (signalSent == 4) {
								if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (3f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (3f));
								}
						}
						

			if (signalSent == 5) {
								if (GameControlScript.currentPlayer == 1 && 
										GameControlScript.enemyMineral >= mineralCost &&
										GameControlScript.enemyMoney >= moneyCost &&
										GameControlScript.enemyMP >= MPcost) {
					
										GameControlScript.enemyMineral -= mineralCost;
										GameControlScript.enemyMoney -= moneyCost;
										GameControlScript.enemyMP -= MPcost;
										StartCoroutine (clicked (6f));
								}
								if (GameControlScript.currentPlayer == 2 && 
										GameControlScript.playerMineral >= mineralCost &&
										GameControlScript.playerMoney >= moneyCost &&
										GameControlScript.playerMP >= MPcost) {
					
										GameControlScript.playerMineral -= mineralCost;
										GameControlScript.playerMoney -= moneyCost;
										GameControlScript.playerMP -= MPcost;
										StartCoroutine (clicked (6f));
								}
						}



				}



		if (signalSent == 6) {
						LevelController.levelTimerStat = 0f;
				}
		}

		public IEnumerator clicked (float coolDown)
		{
				
				SpawnPoint.buttonClick = signalSent;
				LevelController.getFrenzyTrig = signalSent;
				disable = true;
				guiTexture.texture = cooling;
				yield return new WaitForSeconds (coolDown); // waits 3 seconds

				disable = false;
				guiTexture.texture = nonHighlight;

		}
















	    



}
