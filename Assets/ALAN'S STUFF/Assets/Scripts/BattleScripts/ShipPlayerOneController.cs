﻿using UnityEngine;
using System.Collections;

public class ShipPlayerOneController : MonoBehaviour
{

		public bool attacking = false;


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

		}

		void FixedUpdate ()
		{

				if (attacking == true) {
						Vector3 movement = transform.position;
						if (Input.GetKey (KeyCode.W) && (transform.position.y < 7.780773f)) {
								movement.y = transform.position.y + ShipSpeedFixScript.shipOneBattleSpeed;
								transform.position = movement;
				
						}
			
						if (Input.GetKey (KeyCode.S) && (transform.position.y > -3.619221f)) {
				movement.y = transform.position.y - ShipSpeedFixScript.shipOneBattleSpeed;
								transform.position = movement;
				
						}

						if (Input.GetKey (KeyCode.D) && (transform.position.x < -17.60411f)) {
				movement.x = transform.position.x + ShipSpeedFixScript.shipOneBattleSpeed;
								transform.position = movement;
				
						}
			
						if (Input.GetKey (KeyCode.A) && (transform.position.x > -24.80414f)) {
				movement.x = transform.position.x - ShipSpeedFixScript.shipOneBattleSpeed;
								transform.position = movement;
				
						}
		
				}
		
		
		}
}