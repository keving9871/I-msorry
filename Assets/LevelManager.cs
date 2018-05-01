﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour

{


    public float[] spawnDelays;

    float lastSpawnTime = 0;



    int currentIndex = 0;



    public GameObject[] customerPrefabs;

    public List<GameObject> activeCustomers = new List<GameObject>();

    public Transform spawnPoint;



    public GameManager GameManager;

    //public Customer(Sprite sprite, int food, int drink, int women)





    void Start()

    {

        /* 
        Customer customer1 = new Customer(customer1s, 1, 1, 1); 
        Customer customer2 = new Customer(customer2s, 2, 2, 2); 
        Customer customer3 = new Customer(customer3s, 3, 3, 3); 
        Customer customer4 = new Customer(customer4s, 4, 4, 4); 
        Customer customer5 = new Customer(customer5s, 5, 5, 5); 
        Customer customer6 = new Customer(customer6s, 6, 6, 6); 
 
 
      //  Customer[1] = Custom1; 
        Customer[2] = Custom2; 
        Customer[3] = Custom3; 
        Customer[4] = Custom4; 
        Customer[5] = Custom5; 
        Customer[6] = Custom6; 
        */

    }



    void Update()

    {

        if (Time.time - lastSpawnTime > spawnDelays[currentIndex % spawnDelays.Length])

        {

            GameObject newCustomer = Instantiate(customerPrefabs[Random.Range(0, customerPrefabs.Length - 1)], spawnPoint.position, spawnPoint.rotation) as GameObject;

            activeCustomers.Add(newCustomer);



            lastSpawnTime = Time.time;

            currentIndex++;

        }

    }



    void RemoveCustomerFromActiveList(GameObject customer)

    {

        if (activeCustomers.Contains(customer))

        {

            activeCustomers.Remove(customer);

        }

    }





}