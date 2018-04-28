using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prostitute {

   
    public GameObject Prefab;
    
    public int forpreference;

    public Prostitute()
    {
       
    }

    public Prostitute(GameObject Prefab_, int preference)
    {
        Prefab = Prefab_;

        this.forpreference = preference;
    }
}
