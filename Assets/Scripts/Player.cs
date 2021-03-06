﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // members or variables
    
    public float moveSpeed = 7.0f;


public GameObject bulletspawner;
public GameObject bullet;

    // methods or functions
	
	// Update is called once per frame
	void Update () {
		// Player movement
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            //transform.Getchild(0).lookAt()
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    void Shoot(){
        Instantiate(bullet.transform, bulletspawner.transform.position, bulletspawner.transform.rotation);

	}
}