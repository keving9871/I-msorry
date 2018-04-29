using System.Collections;
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
    public GameObject Bourbons;//


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










        // Food(Sprite sprite, int preference)


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

                if (hit.collider.gameObject.tag == "Chef")
                {
                    FoodPanel.SetActive(true);
                    foodpanelopen = true;




                }
                if (hit.collider.gameObject.tag == "Bar")
                {

                    BarPanel.SetActive(true);
                    barpanelopen = true;

                }
                if(hit.collider.gameObject.tag == "Bottle")
                {
                    Alcohols[2].Highlighted = true;
                    Debug.Log("hit");
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
                    Debug.Log("run");
                    for (int i = 0; i < Alcohols.Length; i++)
                    {
                        if(Alcohols[i].Highlighted == true)
                        {
                            Alcohols[i].Highlighted = false;
                            SomethingsHighlighted = false;
                            Debug.Log("off");
                        }
                        Debug.Log(i);
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

}

