using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text RoomsRented;

    public Text DrinksServed;

    public Text FoodServed;

    public Text Total;

    public Text DayTracker;

    public void AssignEndingText (int roomsRented, int drinksServed, int foodServed)
    {
        RoomsRented.text = roomsRented.ToString();
        DrinksServed.text = drinksServed.ToString();
        FoodServed.text = foodServed.ToString();
        Total.text = Total.ToString();
        DayTracker.text = DayTracker.ToString();
    }


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
