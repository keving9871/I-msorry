using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol  {

    public Sprite sprite;
    
    public int forpreference;

    public Alcohol()
    {

    }

    public Alcohol(Sprite sprite,  int preference)
    {
        this.sprite = sprite;
      
        this.forpreference = preference;
    }
}
