using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer {
   public GameObject customer;
    public GameObject customerspawned;


    public bool killer = false;
    public int Foodpreference;
    public int Drinkpreference;
    public int Womenpreference;

    public int tablenumber;

    public bool bubble;

    public bool spawned;

    public Customer()
    {

    }

    public Customer(int food, int drink, GameObject customer_)
    {
      this.customer = customer_;
        
      
        this.Foodpreference = food;
        this.Drinkpreference = drink;
       
    }

}
