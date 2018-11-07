using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

//Members
public float moveSpeed = 7.of;

private float maxDistance = 0.of;
	
//functions

	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
		timePassed += 1 * Time.deltaTime;
		if(timePassed >= 5)
		{
			Destroy(this.gameobject);
		} 

		
	}
}
