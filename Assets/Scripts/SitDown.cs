﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitDown : MonoBehaviour
{
    public GameObject Sitting;

    public Transform table1;
    public Transform table2;
    public Transform table3;
    public Transform table4;
    public bool sitting = false;

    public LevelManager LevelManager;
    public GameManager gameManager;
    // Use this for initialization
    void Start()
    {

        table1 = GameObject.FindGameObjectWithTag("T1S").GetComponent<Transform>();
        table2 = GameObject.FindGameObjectWithTag("T2S").GetComponent<Transform>();
        table3 = GameObject.FindGameObjectWithTag("T3S").GetComponent<Transform>();
        table4 = GameObject.FindGameObjectWithTag("T4S").GetComponent<Transform>();

        LevelManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelManager>();
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "T1" && gameManager.table1taken == false && sitting == false)
        {
            Debug.Log("y");
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting, table1.position, Quaternion.identity);
            gameManager.table1taken = true;
            gameManager.CustomerSpawned = false;
            sitting = true;
            if (this.gameObject == LevelManager.Bigboys)
            {
                LevelManager.Customers[0].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Smallboys)
            {
                LevelManager.Customers[1].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Farmers)
            {
                LevelManager.Customers[2].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Gentlemans)
            {
                LevelManager.Customers[3].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Crazys)
            {
                LevelManager.Customers[4].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Greenjackets)
            {
                LevelManager.Customers[5].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Greenboys)
            {
                LevelManager.Customers[6].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Yellowboys)
            {
                LevelManager.Customers[7].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Blueboys)
            {
                LevelManager.Customers[8].tablenumber = 1;
            }
            if (this.gameObject == LevelManager.Pinkboys)
            {
                LevelManager.Customers[9].tablenumber = 1;
            }

        }
        else if (col.gameObject.tag == "T3" && gameManager.table3taken == false && sitting == false)
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting, table3.position, Quaternion.identity);
            gameManager.table3taken = true;
            gameManager.CustomerSpawned = false;
            sitting = true;
           

        }
        else if (col.gameObject.tag == "T4" && gameManager.table4taken == false && sitting == false)
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting, table4.position, Quaternion.identity);
            gameManager.table4taken = true;
            gameManager.CustomerSpawned = false;
            sitting = true;
      

        }
        else if (col.gameObject.tag == "T2" && gameManager.table2taken == false && sitting == false)
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting, table2.position, Quaternion.identity);
            gameManager.table2taken = true;
            gameManager.CustomerSpawned = false;
            sitting = true;
          

        }
    }
}
