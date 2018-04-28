using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food {

    public Sprite sprite;
    public string name;
    public int forpreference;

    public Food()
    {

    }

    public Food(Sprite sprite, int preference)
    {
        this.sprite = sprite;
        
        this.forpreference = preference;
    }
}
