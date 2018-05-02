﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour

{
    public float spawnDelays;

    float lastSpawnTime = 0;
    
    int currentIndex = 0;

    public Customer[] Customers;

    public GameObject Bigboys; //1
    public GameObject Smallboys; //2
    public GameObject Blueboys; //3
    public GameObject Yellowboys; //4
    public GameObject Pinkboys; //5
    public GameObject Greenjackets; //6
    public GameObject Crazys; //7
    public GameObject Gentlemans; //8
    public GameObject Farmers; //9
    public GameObject Greenboys; //10

    public List<GameObject> activeCustomers = new List<GameObject>();

    public Transform spawnPoint;

    public int random;

    public Customer Spawner;

    public GameManager GameManager;

    //public Customer(Sprite sprite, int food, int drink, int women)
    private void Start()
    {
        Customer Bigboy = new Customer(1, 2, Bigboys);
        Customer Smallboy = new Customer(2, 3, Smallboys);
        Customer Farmer = new Customer(3, 4, Farmers);
        Customer Gentleman = new Customer(4, 1, Gentlemans);
        Customer Crazy = new Customer(1, 2, Crazys);
        Customer Greenjacket = new Customer(2, 3, Greenjackets);
        Customer Blueboy = new Customer(3, 4, Blueboys);
        Customer Yellowboy = new Customer(4, 1, Yellowboys);
        Customer Greenboy = new Customer(1, 2, Greenboys);
        Customer Pinkboy = new Customer(2, 3, Pinkboys);



        Customers = new Customer[10];

        Customers[0] = Bigboy;
        Customers[1] = Smallboy;
        Customers[2] = Farmer;
        Customers[3] = Gentleman;
        Customers[4] = Crazy;
        Customers[5] = Greenjacket;
        Customers[6] = Blueboy;
        Customers[7] = Yellowboy;
        Customers[8] = Blueboy;
        Customers[9] = Pinkboy;

        random = Random.Range(0, Customers.Length - 1);

        GameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        Instantiate<GameObject>(Customers[random].customer, spawnPoint.position, spawnPoint.rotation);
        Customers[random].spawned = true;
        Customers[random].killer = true;

    }

    void Update()

    {

        if (Time.time - lastSpawnTime > spawnDelays && GameManager.CustomerSpawned == false)

        {

            Spawner = FindCustomerRandom();
            if(Spawner == null)
            {
                Spawner = FindCustomerStart();
            }
            Instantiate<GameObject>(Spawner.customer, spawnPoint.position, spawnPoint.rotation);

            



            lastSpawnTime = Time.time;

            currentIndex++;
            GameManager.CustomerSpawned = true;

        }

    }



    void RemoveCustomerFromActiveList(GameObject customer)

    {
        Debug.Log("z");

        if (activeCustomers.Contains(customer))

        {
            Debug.Log("y");
            activeCustomers.Remove(customer);

        }

    }

    public Customer FindCustomerRandom()
    {

        for (int i = random; i < Customers.Length; i++)
        {
            if (Customers[i].spawned == false)
            {
                Customers[i].spawned = true;
                return (Customers[i]);
            }
            

        }
        return (null);
    }
    public Customer FindCustomerStart()
    {
        for (int i = 0; i < Customers.Length; i++)
        {
            if (Customers[i].spawned == false)
            {
                Customers[i].spawned = true;
                return (Customers[i]);
            }


        }
        return (null);
    }




}