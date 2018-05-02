using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food {

    public GameObject Prefab;

    public GameObject FoodMade;
    public string name;
    public int forpreference;

    public bool served;

    public bool Highlighted;

    public Food()
    {

    }

    public Food(GameObject Prefab_, int preference, bool served_, bool highlighted_)
    {
        Prefab = Prefab_;

        this.forpreference = preference;
        this.served = served_;
        Highlighted = highlighted_;
    }
}
