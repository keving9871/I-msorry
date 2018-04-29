﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Prostitute[] Prostitutes;

    public GameObject Berthas; //1
    public GameObject Amalias; //2
    public GameObject Eleanors; //3
    public GameObject Fannies; //4
    public GameObject Mollies; //5
    public GameObject Pearls; //6
    public GameObject Ais; //7
    public GameObject Vanessas; //8
    public GameObject Julias; //9
    public GameObject Alices; //10

    

    public Alcohol[] Alcohols;

    public GameObject Gins; //1
    public GameObject Liquors;//2
    public GameObject Whiskeys;//3
    public GameObject Bourbons;//4




    public Food[] Foods;

    public GameObject Chickens;//1
    public GameObject BGs;//2
    public GameObject BBs;//3
    public GameObject Steaks;//4


    public GameObject Child;
    public GameObject Parent;
    public GameObject BarPanel;
    public GameObject FoodPanel;

    public bool barpanelopen = false;
    public bool foodpanelopen = false;


    //score 

    public int RoomsRented;
    public int FoodSold;
    public int DrinksMade;

    public int[] RoomsRentedScores;
    public int[] FoodSoldScores;
    public int[] DrinksMadeScores;


    public bool SomethingsHighlighted = false;



    // Use this for initialization
    void Start()
    {

        //Prostitute(Sprite sprite, string name, int preference, highlighted)
        Prostitute Bertha = new Prostitute(Berthas, 1, false);
        Prostitute Amalia = new Prostitute(Amalias, 2, false);
        Prostitute Eleanor = new Prostitute(Eleanors, 3, false);
        Prostitute Fannie = new Prostitute(Fannies, 4, false);
        Prostitute Mollie = new Prostitute(Mollies, 5, false);
        Prostitute Pearl = new Prostitute(Pearls, 6, false);
        Prostitute Ai = new Prostitute(Ais, 7, false);
        Prostitute Vanessa = new Prostitute(Vanessas, 8, false);
        Prostitute Julia = new Prostitute(Julias, 9, false);
        Prostitute Alice = new Prostitute(Alices, 10, false);

        Prostitutes = new Prostitute[11];

        Prostitutes[1] = Bertha;
        Prostitutes[2] = Amalia;
        Prostitutes[3] = Eleanor;
        Prostitutes[4] = Fannie;
        Prostitutes[5] = Mollie;
        Prostitutes[6] = Pearl;
        Prostitutes[7] = Ai;
        Prostitutes[8] = Vanessa;
        Prostitutes[9] = Julia;
        Prostitutes[10] = Alice;

        //Alcohol(Sprite sprite, string name, int preference, served, highlighted)
        Alcohol Gin = new Alcohol(Gins, 1, false, false);
        Alcohol Liquor = new Alcohol(Liquors, 2, false, false);
        Alcohol Whiskey = new Alcohol(Whiskeys, 3, false, false);
        Alcohol Bourbon = new Alcohol(Bourbons, 4, false, false);

        Alcohols = new Alcohol[5];

        Alcohols[1] = Gin;
        Alcohols[2] = Liquor;
        Alcohols[3] = Whiskey;
        Alcohols[4] = Bourbon;

        //public Food(GameObject Prefab_, int preference, bool served_, bool highlighted_)
        Food Steak = new Food(Steaks, 1, false, false);
        Food BB = new Food(BBs, 2, false, false);
        Food BG = new Food(BGs, 3, false, false);
        Food Chicken = new Food(Chickens, 4, false, false);

        Foods = new Food[5];

        Foods[1] = Steak;
        Foods[2] = BB;
        Foods[3] = BG;
        Foods[4] = Chicken;


        // Customer(Sprite sprite, int food, int drink, int women)



    }





    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Scene Management && point and click mechanic
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.transform.forward);
            if (hit)
            {

                if (hit.collider.gameObject.tag == "Chef" && SomethingsHighlighted == false)
                {
                    FoodPanel.SetActive(true);
                    foodpanelopen = true;




                }
                if (hit.collider.gameObject.tag == "Bar" && SomethingsHighlighted == false)
                {

                    BarPanel.SetActive(true);
                    barpanelopen = true;

                }
                if(hit.collider.gameObject.tag == "Bottle" && SomethingsHighlighted == false)
                {
                    Alcohols[2].Highlighted = true;
                   
                    SomethingsHighlighted = true;

                }
                if (hit.collider.gameObject.tag == "Steak" && SomethingsHighlighted == false)
                {
                    Foods[1].Highlighted = true;

                    SomethingsHighlighted = true;

                }
                if (hit.collider.gameObject.tag == "BB" && SomethingsHighlighted == false)
                {
                    Foods[2].Highlighted = true;

                    SomethingsHighlighted = true;

                }
                if (hit.collider.gameObject.tag == "BG" && SomethingsHighlighted == false)
                {
                    Foods[3].Highlighted = true;

                    SomethingsHighlighted = true;

                }
                if (hit.collider.gameObject.tag == "Chicken" && SomethingsHighlighted == false)
                {
                    Foods[4].Highlighted = true;

                    SomethingsHighlighted = true;

                }

            }
            else
            {
                Debug.Log("else");
                if (foodpanelopen == true)
                {
                  //  FoodPanel.SetActive(false);
                   // foodpanelopen = false;
                }
                if (barpanelopen == true)
                {
                   // BarPanel.SetActive(false);
                   // barpanelopen = false;
                }
                if(SomethingsHighlighted == true)
                {
                    
                    for (int i = 1; i < Alcohols.Length; i++)
                    {
                        if(Alcohols[i].Highlighted == true)
                        {
                            Alcohols[i].Highlighted = false;
                            SomethingsHighlighted = false;
                            
                        }
                        
                    }
                    
                }

            }

        }
    }

    public void BarOrder(int OrderNumber)
    {
        
        MakeDrink(Alcohols[OrderNumber].Prefab);
        Debug.Log("barorder");
    }
    
    public void MakeDrink(GameObject DrinkPrefab)
    {
        Instantiate<GameObject>(DrinkPrefab);
        Debug.Log("makedrink");
        
    }
    public void LiqourOrder()
    {
        if(Alcohols[2].served == false)
        {
            BarOrder(2);
            Alcohols[2].served = true;
            Debug.Log("liqourorder");
        }
        Debug.Log("x");
        BarPanel.SetActive(false);

    }
    public void GinOrder()
    {
        if (Alcohols[1].served == false)
        {
            BarOrder(1);
            Alcohols[1].served = true;
        }
        BarPanel.SetActive(false);
    }
    public void WhiskeyOrder()
    {
        if (Alcohols[3].served == false)
        {
            BarOrder(3);
            Alcohols[3].served = true;
        }
        BarPanel.SetActive(false);
    }
    public void BourbonOrder()
    {
        if (Alcohols[4].served == false)
        {
            BarOrder(4);
            Alcohols[4].served = true;
        }
        BarPanel.SetActive(false);
    }
    public void Highlight(GameObject gameObject)
    {
       // gameObject.GetComponent<SpriteRenderer>.sprite = (gameObject)Highlighted;
    }
    public void FoodOrder(int OrderNumber)
    {

        MakeFood(Foods[OrderNumber].Prefab);
       
    }

    public void MakeFood(GameObject DrinkPrefab)
    {
        Instantiate<GameObject>(DrinkPrefab);
        

    }
    public void SteakOrder()
    {
        if (Foods[1].served == false)
        {
            FoodOrder(1);
            Foods[1].served = true;         
        }      
        FoodPanel.SetActive(false);
    }
    public void BBOrder()
    {
        if (Foods[2].served == false)
        {
            FoodOrder(2);
            Foods[2].served = true;
        }
        FoodPanel.SetActive(false);
    }
    public void BGOrder()
    {
        if (Foods[3].served == false)
        {
            FoodOrder(3);
            Foods[3].served = true;
        }
        FoodPanel.SetActive(false);
    }
    public void ChickenOrder()
    {
        if (Foods[4].served == false)
        {
            FoodOrder(4);
            Foods[4].served = true;
        }
        FoodPanel.SetActive(false);
    }
 
}

