﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {


    GameObject car;
    GameObject flag;
    GameObject distance;



    // Use this for initialization
    void Start () {

        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
		
	}
	
	// Update is called once per frame
	void Update () {
        float Length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "ゴールまで" + Length.ToString("F2") + "m";
		
	}
}
