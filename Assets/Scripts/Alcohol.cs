using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol  {

    public GameObject drinkobject;

    public GameObject drinkmade;
    
    public int forpreference;

    public bool served;

    public bool Highlighted;

    public Alcohol()
    {

    }

    public Alcohol(GameObject drinkobject_, int preference, bool served_ , bool highlighted_)
    {
        drinkobject = drinkobject_;

        this.forpreference = preference;
        this.served = served_;
        Highlighted = highlighted_;
    }
}
