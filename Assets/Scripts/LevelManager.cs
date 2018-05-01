﻿using System.Collections;
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