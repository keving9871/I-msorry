using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prostitute {

   
    public GameObject Prefab;
    
    public int forpreference;

    public bool Highlighted;

    public Prostitute()
    {
       
    }

    public Prostitute(GameObject Prefab_, int preference, bool highlighted_)
    {
        Prefab = Prefab_;

        this.forpreference = preference;
        Highlighted = highlighted_;
    }
}
