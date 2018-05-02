using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrderSystem : MonoBehaviour {

    public Sprite Bottle;
    public Sprite Shot;
    public Sprite Glass;
    public Sprite BottleFat;

    public Sprite Steak;
    public Sprite BB;
    public Sprite BG;
    public Sprite Chicken;

    public Sprite Girl;

    public GameObject bubble;

    public int CustomerNumber;

  

   
    

    // Use this for initialization
    void Start () {
	
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DrinkOrderSystem(int ordernumber)
    {
        
        GetComponent<SpriteRenderer>().enabled = true;
        if(ordernumber == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Bottle;
        }
        if(ordernumber == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Shot;
        }
        if (ordernumber == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Glass;
        }
        if (ordernumber == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BottleFat;
        }

    }
    public void FoodOrderSystem(int ordernumber)
    {
        GetComponent<SpriteRenderer>().enabled = true;
        if (ordernumber == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Steak;
        }
        if (ordernumber == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BB;
        }
        if (ordernumber == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BG;
        }
        if (ordernumber == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Chicken;
        }

    }
    public void OrderBottle()
    {
        DrinkOrderSystem(1);
    }
    public void OrderShot()
    {
        DrinkOrderSystem(2);
    }
    public void OrderGlass()
    {
        DrinkOrderSystem(3);
    }
    public void OrderBottleFat()
    {
        DrinkOrderSystem(4);
    }
    public void OrderSteak()
    {
        FoodOrderSystem(1);
    }
    public void OrderBB()
    {
        FoodOrderSystem(2);
    }
    public void OrderBG()
    {
        FoodOrderSystem(3);
    }
    public void OrderChicken()
    {
        FoodOrderSystem(4);
    }
    public void Stop()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void OrderGirl()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Girl;
    }
  
}
