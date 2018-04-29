using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol  {

    public GameObject Prefab;
    
    public int forpreference;

    public bool served;

    public bool Highlighted;

    public Alcohol()
    {

    }

    public Alcohol(GameObject Prefab_, int preference, bool served_ , bool highlighted_)
    {
        Prefab = Prefab_;

        this.forpreference = preference;
        this.served = served_;
        Highlighted = highlighted_;
    }
}
