using UnityEngine;
using System.Collections;

public class DeletePressedScript : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
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
