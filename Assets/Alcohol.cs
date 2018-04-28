using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol  {

    public GameObject Prefab;
    
    public int forpreference;

    public Alcohol()
    {

    }

    public Alcohol(GameObject Prefab_, int preference)
    {
        Prefab = Prefab_;

        this.forpreference = preference;
    }
}
