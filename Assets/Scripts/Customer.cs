using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour {
   // public GameObject customer;

    public bool killer = false;
    public int Foodpreference;
    public int Drinkpreference;
    public int Womenpreference;

    public Customer()
    {

    }

    public Customer(int food, int drink, int women)
    {
      //  this.customer = customer_;
      
        this.Foodpreference = food;
        this.Drinkpreference = drink;
        this.Womenpreference = women;
    }

}
