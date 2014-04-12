using UnityEngine;
using System.Collections;

public class pleasedelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp (KeyCode.Z))
		{
			GameObject ShipAttackP1 = Instantiate (GridSetupScript.controlCoreOneStat, new Vector2 (-21.30412f, -2.919221f), Quaternion.identity) as GameObject;
			ShipAttackP1.GetComponent<ShipPlayerOneController>().attacking = true;
		}
	
	}
}
