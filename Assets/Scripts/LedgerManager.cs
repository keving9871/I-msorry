using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LedgerManager : MonoBehaviour {

    public GameObject roomsRentedtext;
    public GameObject foodServedtext;
    public GameObject drinksServedtext;
    public GameObject daytext;
    public GameObject totaltext;

    public GameManager manager;

     void Start()
    {
       manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    void Update ()
    {
       /* 
        roomsRentedtext.gameObject.GetComponent<Text>().text = (manager.RoomsRented);
        foodServedtext.gameObject.GetComponent<Text>().text = (manager.FoodSold);
        drinksServedtext.gameObject.GetComponent<Text>().text = (GameManager.drinksMade);
        daytext.gameObject.GetComponent<Text>().text = (GameManager.);
        totaltext.gameObject.GetComponent<Text>().text = (GameManager.);
        */
         
    }
}
