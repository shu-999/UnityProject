﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour {



	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "InkBall(Clone)")
        {

        }
    }
}
