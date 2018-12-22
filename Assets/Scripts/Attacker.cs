﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Attacker : MonoBehaviour {

    [Range(-1f, 1.5f)]
    float currentSpeed;
    GameObject currentTarget;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);

	}
    void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(name + "trigger enter");

    }

    public void SetSpeed (float speed)
    {

        currentSpeed = speed;

    }

    public void StrikeCurrentTarget(float damage)
    {

        Debug.Log(name + " caused damage: " + damage);

    }

    public void Attack(GameObject obj)
    {

        currentTarget = obj;


    }

}
