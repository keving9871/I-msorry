using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer {
    public Sprite sprite;

    public bool killer = false;
    public int Foodpreference;
    public int Drinkpreference;
    public int Womenpreference;

    public Customer()
    {

    }

    public Customer(Sprite sprite, int food, int drink, int women)
    {
        this.sprite = sprite;
      
        this.Foodpreference = food;
        this.Drinkpreference = drink;
        this.Womenpreference = women;
    }

}
