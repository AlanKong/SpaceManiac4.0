﻿using UnityEngine;
using System.Collections;

public class FinishBuildButton : MonoBehaviour
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

				Vector3 worldLoc;
				worldLoc.y = 0f;
				worldLoc.z = -10;
				worldLoc.x = 0f;

				MapCameraScript.movementoo = worldLoc;

				GameControlScript.currentScene = 0;
		}
}
