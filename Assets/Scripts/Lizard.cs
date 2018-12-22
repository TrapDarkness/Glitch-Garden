﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]

public class Lizard : MonoBehaviour
{

    Animator anim;
    Attacker attacker;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject obj = collision.gameObject;

        //Leave method if not colliding with defender
        if (!obj.GetComponent<Defender>())
        {

            return;

        }

        if (obj.GetComponent<Stone>())
        {

            anim.SetBool("isAttacking", true);
            attacker.Attack(obj);

        }

        Debug.Log("Lizard collided with " + collision);

    }

}
