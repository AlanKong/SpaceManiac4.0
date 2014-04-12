using UnityEngine;
using System.Collections;

public class DeletePressedScript : MonoBehaviour
{
	public Sprite nonHighlight;
	public Sprite highlight;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		 if (GridSetupScript.deletePressed == true || GridSetupScript.deletePressedP2 == true) {
						GetComponent<SpriteRenderer> ().sprite = highlight;
				} else {

			GetComponent<SpriteRenderer> ().sprite = nonHighlight;
				}
		}

		void OnMouseDown ()
		{
				if (GameControlScript.currentPlayer == 1) {
						GridSetupScript.deletePressed = true;
				}
				if (GameControlScript.currentPlayer == 2) {
						GridSetupScript.deletePressedP2 = true;
				}
		}
}
