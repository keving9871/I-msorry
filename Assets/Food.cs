using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food {

    public GameObject Prefab;
    public string name;
    public int forpreference;

    public Food()
    {

    }

    public Food(GameObject Prefab_, int preference)
    {
        Prefab = Prefab_;

        this.forpreference = preference;
    }
}
