using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour
{
		public Sprite nonHighlight;
		public Sprite select;
		public bool selected = false;
		public bool occupied = false;
		public float xCoord;
		public float yCoord;	

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (occupied == true) {
						GetComponent<SpriteRenderer> ().sprite = nonHighlight;
						selected = false;
				} 

		if (GridSetupScript.deletePressed == true || GridSetupScript.deletePressedP2 == true) {
			GetComponent<SpriteRenderer> ().sprite = nonHighlight;
			selected = false;
			GridSetupScript.somethingSelected = false;
			GridSetupScript.selectedTile = null;

				}
		}

		void OnMouseDown ()
		{
				if (GameControlScript.currentPlayer == 1) {
						if (selected == false && GridSetupScript.somethingSelected == false && occupied == false) {
								GetComponent<SpriteRenderer> ().sprite = select;
								selected = true;
								GridSetupScript.somethingSelected = true;				
								GridSetupScript.selectedTile = gameObject;
						} else if (selected == true && GridSetupScript.somethingSelected == true) {
								GetComponent<SpriteRenderer> ().sprite = nonHighlight;
								selected = false;
								GridSetupScript.somethingSelected = false;
								GridSetupScript.selectedTile = null;
						}
						GridSetupScript.deletePressed = false;
				}
				if (GameControlScript.currentPlayer == 2) {
						if (selected == false && GridSetupScript.somethingSelectedP2 == false && occupied == false) {
								GetComponent<SpriteRenderer> ().sprite = select;
								selected = true;
								GridSetupScript.somethingSelectedP2 = true;				
								GridSetupScript.selectedTileP2 = gameObject;
						} else if (selected == true && GridSetupScript.somethingSelectedP2 == true) {
								GetComponent<SpriteRenderer> ().sprite = nonHighlight;
								selected = false;
								GridSetupScript.somethingSelectedP2 = false;
								GridSetupScript.selectedTileP2 = null;
						}
						GridSetupScript.deletePressedP2 = false;
				}
		}
}
