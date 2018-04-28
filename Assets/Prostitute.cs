using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prostitute {

    public Sprite sprite;
    
    public int forpreference;

    public Prostitute()
    {

    }

    public Prostitute(Sprite sprite, int preference)
    {
        this.sprite = sprite;
       
        this.forpreference = preference;
    }
}
