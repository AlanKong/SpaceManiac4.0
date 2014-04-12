using UnityEngine;
using System.Collections;

public class TestModScript : MonoBehaviour
{
	
		public float replaceX;
		public float replaceY;
		float cornerX = 10.6f;
		float cornerY = -4f;
		float cornerXP2 = 25.2f;
		float cornerYP2 = -4f;
		public bool core = false;
		//public bool attachedCore = false;
		public bool module = true;
		public bool onGrid = false;
		public bool inBattle = false;
		public bool coreUp = false;
		public bool coreDown = false;
		public bool coreRight = false;
		public bool coreLeft = false;
		public bool noCore = true;



		///////////////////////////////////////////////////////////////

		public int priceMP;
		public int priceMoney;
		public int priceMineral;
		public float boost;
		public int HP;
		public int damage;
		public bool isTurret;
		public GameObject shot;
		public float fireInterval;
		public float lastShot;

		// Use this for initialization
		void Start ()
		{
				lastShot = Time.time;
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (coreUp == true || coreDown == true || coreLeft == true || coreRight == true) {
						noCore = false;
				} else {
						noCore = true;
				}

				if (noCore == true && (onGrid == true || inBattle == true)) {
						
						if (GameControlScript.currentPlayer == 1) {
								
								StartCoroutine (deleteMod (gameObject));
								GridSetupScript.selectedTile = GridSetupScript.tileArray [(int)replaceX, (int)replaceY];
								GridSetupScript.selectedTile.GetComponent<TileScript> ().occupied = false;
								GridSetupScript.somethingSelected = false;
						}
						if (GameControlScript.currentPlayer == 2) {
								
								StartCoroutine (deleteMod (gameObject));
								GridSetupScript.selectedTileP2 = GridSetupScript.tileArrayP2 [(int)replaceX, (int)replaceY];
								GridSetupScript.selectedTileP2.GetComponent<TileScript> ().occupied = false;
								GridSetupScript.somethingSelectedP2 = false;
						}

				}

				if (isTurret == true && inBattle == true) {
						if (Input.GetKey (KeyCode.LeftShift)) {
								if (Time.time - lastShot > fireInterval) {
										Vector3 turretLoc = transform.position;
										Vector2 speed = new Vector2 (10, 10);
										Vector2 direction = new Vector2 (0, 1);
										Vector2 movement = new Vector2 (speed.x * direction.x, speed.y * direction.y);
										GameObject newShot = Instantiate (shot, turretLoc, Quaternion.identity) as GameObject;
										newShot.GetComponent<ShotScript> ().damage = damage;
										newShot.rigidbody2D.velocity = movement;
										lastShot = Time.time;
								}

						}


				}
		
		}
	
		void OnMouseDown ()
		{
				if (GameControlScript.currentPlayer == 1) {
						if (core == false && GridSetupScript.deletePressed == true && onGrid == true) {


								StartCoroutine (deleteMod (gameObject));
								GridSetupScript.selectedTile = GridSetupScript.tileArray [(int)replaceX, (int)replaceY];
								GridSetupScript.selectedTile.GetComponent<TileScript> ().occupied = false;
								GridSetupScript.somethingSelected = false;
								GridSetupScript.deletePressed = false;

						} else if (core == false && GridSetupScript.deletePressed == false && onGrid == false &&
			           GameControlScript.playerMP >= priceMP &&
			           GameControlScript.playerMineral >= priceMineral &&
			           GameControlScript.playerMoney >= priceMoney) {
								replaceX = GridSetupScript.selectedTile.GetComponent<TileScript> ().xCoord;
								replaceY = GridSetupScript.selectedTile.GetComponent<TileScript> ().yCoord;
								GridSetupScript.selectedTile.GetComponent<TileScript> ().occupied = true;
								GridSetupScript.somethingSelected = false;
								GridSetupScript.recentDelete = GridSetupScript.selectedTile;
								GridSetupScript.selectedTile = null;
								GridSetupScript.shipArray [(int)replaceX, (int)replaceY] = Instantiate (gameObject, new Vector3 (cornerX + replaceX / 1.85f, cornerY + replaceY / 1.85f, -1f), Quaternion.identity) as GameObject;
								GridSetupScript.shipArray [(int)replaceX, (int)replaceY].transform.parent = GridSetupScript.controlCoreOneStat.transform;
								GameControlScript.playerMP -= priceMP;
								GameControlScript.playerMoney -= priceMoney;
								GameControlScript.playerMineral -= priceMineral;
								ShipSpeedFixScript.shipOneFixedSpeed += boost;

			
			
			
						}
				}
				if (GameControlScript.currentPlayer == 2) {
						if (core == false && GridSetupScript.deletePressedP2 == true && onGrid == true) {
				
								
								StartCoroutine (deleteMod (gameObject));
								GridSetupScript.selectedTileP2 = GridSetupScript.tileArrayP2 [(int)replaceX, (int)replaceY];
								GridSetupScript.selectedTileP2.GetComponent<TileScript> ().occupied = false;
								GridSetupScript.somethingSelectedP2 = false;
								GridSetupScript.deletePressedP2 = false;
				
			} else if (core == false && GridSetupScript.deletePressedP2 == false && onGrid == false &&
			           GameControlScript.enemyMP >= priceMP &&
			           GameControlScript.enemyMineral >= priceMineral &&
			           GameControlScript.enemyMoney >= priceMoney) {
								replaceX = GridSetupScript.selectedTileP2.GetComponent<TileScript> ().xCoord;
								replaceY = GridSetupScript.selectedTileP2.GetComponent<TileScript> ().yCoord;
								GridSetupScript.selectedTileP2.GetComponent<TileScript> ().occupied = true;
								GridSetupScript.somethingSelectedP2 = false;
								GridSetupScript.recentDeleteP2 = GridSetupScript.selectedTileP2;
								GridSetupScript.selectedTileP2 = null;
								GridSetupScript.shipArrayP2 [(int)replaceX, (int)replaceY] = Instantiate (gameObject, new Vector3 (cornerXP2 + replaceX / 1.85f, cornerYP2 + replaceY / 1.85f, -1f), Quaternion.identity) as GameObject;
								GridSetupScript.shipArrayP2 [(int)replaceX, (int)replaceY].transform.parent = GridSetupScript.controlCoreTwoStat.transform;
								GameControlScript.enemyMP -= priceMP;
								GameControlScript.enemyMoney -= priceMoney;
								GameControlScript.enemyMineral -= priceMineral;
								ShipSpeedFixScript.shipTwoFixedSpeed += boost;
						}
				}
		}

		void OnTriggerEnter2D (Collider2D enemyBullet)
		{
				if (enemyBullet.tag == "bullets") {
						HP -= enemyBullet.GetComponent<EnemyShotDamage> ().enemyShotDamage;
						Destroy (enemyBullet.gameObject);
				}

		if (enemyBullet.tag == "minion") {
			HP -= 1;
		}

				if (HP == 0) { 


						StartCoroutine (deleteMod (gameObject));


				}
		}

		public IEnumerator deleteMod (GameObject deletedMod)
	{
				Vector2 destroyStep1 = new Vector2 (500, 500);
				deletedMod.transform.position = destroyStep1;

				yield return new WaitForSeconds (0.05f); // waits 3 seconds
				
		if (GameControlScript.currentPlayer == 1 && BattleScript.battleBegin == false) {
			ShipSpeedFixScript.shipOneFixedSpeed -= boost;
			
		}
		
		if (GameControlScript.currentPlayer == 1 && BattleScript.battleBegin == true) {
			ShipSpeedFixScript.shipOneBattleSpeed -= boost;

		}
		
		if (GameControlScript.currentPlayer == 2 && BattleScript.battleBegin == false) {
			ShipSpeedFixScript.shipTwoFixedSpeed -= boost;
			
		}
		if (GameControlScript.currentPlayer == 2 && BattleScript.battleBegin == true) {
			ShipSpeedFixScript.shipTwoBattleSpeed -= boost;

			
		}
		if(core == true)
		{
			ShipSpeedFixScript.shipBattleCoreCount--;
		}

				Destroy (gameObject);
		}
}
