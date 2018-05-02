using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderShit : MonoBehaviour {

    public Customer currentcustomer;

    public CustomerOrderSystem COS;

    public LevelManager LevelManager;
    public GameManager gameManager;

    public bool yes = false;

    public GameObject BigBoySitting;
    public GameObject SmallBoySitting;
    public GameObject GreenBoySitting;
    public GameObject YellowBoySitting;
    public GameObject PinkBoySitting;
    public GameObject BlueBoySitting;
    public GameObject CrazySitting;
    public GameObject GreenJacketSitting;
    public GameObject GentlemanSitting;
    public GameObject FarmerSitting;

   

   


    // Use this for initialization
    void Start () {
        LevelManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<LevelManager>();
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        if (this.gameObject == BigBoySitting)
        {
            currentcustomer = LevelManager.Customers[0];
        }
        if (this.gameObject == SmallBoySitting)
        {
            currentcustomer = LevelManager.Customers[1];
        }
        if (this.gameObject == FarmerSitting)
        {
            currentcustomer = LevelManager.Customers[2];
        }
        if (this.gameObject == GentlemanSitting)
        {
            currentcustomer = LevelManager.Customers[3];
        }
        if (this.gameObject == CrazySitting)
        {
            currentcustomer = LevelManager.Customers[4];
        }
        if (this.gameObject == GreenJacketSitting)
        {
            currentcustomer = LevelManager.Customers[5];
        }
        if (this.gameObject == GreenBoySitting)
        {
            currentcustomer = LevelManager.Customers[6];
        }
        if (this.gameObject == YellowBoySitting)
        {
            currentcustomer = LevelManager.Customers[7];
        }
        if (this.gameObject == BlueBoySitting)
        {
            currentcustomer = LevelManager.Customers[8];
        }
        if (this.gameObject == PinkBoySitting)
        {
            currentcustomer = LevelManager.Customers[9];
        }
        
          if (currentcustomer.Drinkpreference == 1)
          {
              Invoke("InvokeOrderBottle", 2f);
          }
          if (currentcustomer.Drinkpreference == 2)
          {
              Invoke("InvokeOrderShot", 2f);
          }
          if (currentcustomer.Drinkpreference == 3)
          {
              Invoke("InvokeOrderGlass", 2f);
          }
          if (currentcustomer.Drinkpreference == 4)
          {
              Invoke("InvokeOrderBottleFat", 2f);
          }

        

        //  if(this.gameObject)
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void InvokeOrderBottle()
    {

        COS.OrderBottle();
        
    }
    public void InvokeOrderShot()
    {
        COS.OrderShot();
        
    }
    public void InvokeOrderGlass()
    {
        COS.OrderGlass();
        
    }
    public void InvokeOrderBottleFat()
    {
        COS.OrderBottleFat();
     
    }
    public void GiveDrink(Alcohol drink)
    {
        if(drink.forpreference == currentcustomer.Drinkpreference)
        {
            Destroy(drink.drinkmade);
            drink.served = false;
            Debug.Log("drinkgone");          
            Invoke("OrderFood", 5f);
            COS.Stop();
        }
        else
        {
            Debug.Log("delse");
        }
    }
    public void GiveFood(Food food)
    {
        if (food.forpreference == currentcustomer.Foodpreference)
        {
            Destroy(food.FoodMade);
            food.served = false;
            Debug.Log("foodgone");
            COS.Stop();
            Invoke("OrderGirl", 5f);

        }
        else
        {
            Debug.Log("felse");
        }
    }
   public void OrderFood()
    {
        Debug.Log("OrderFood");
        if (currentcustomer.Foodpreference == 1)
        {
            Invoke("InvokeSteakOrder", 2f);
        }
        if (currentcustomer.Foodpreference == 2)
        {
            Invoke("InvokeBBOrder", 2f);
        }
        if (currentcustomer.Foodpreference == 3)
        {
            Invoke("InvokeBGOrder", 2f);
        }
        if (currentcustomer.Foodpreference == 4)
        {
            Invoke("InvokeChickenOrder", 2f);
        }
    }
    public void InvokeSteakOrder()
    {
        COS.OrderSteak();
       
    }
    public void InvokeBBOrder()
    {
        COS.OrderBB();
        
    }
    public void InvokeBGOrder()
    {
        COS.OrderBG();
   
    }
    public void InvokeChickenOrder()
    {
        COS.OrderChicken();
       
    }
    public void OrderGirl()
    {
        COS.OrderGirl();
    }
    public void GiveGirl(Prostitute girl)
    {
        Debug.Log(currentcustomer.tablenumber);
        Destroy(girl.Girlmade);
        if(currentcustomer.killer == true)
        {
            girl.killed = true;
        }
        girl.rented = true;
        Destroy(this.gameObject);
        gameManager.CustomerSpawned = false;
        if(currentcustomer.tablenumber == 1)
        {
            gameManager.table1taken = false;
        }
        if (currentcustomer.tablenumber == 2)
        {
            gameManager.table2taken = false;
        }
        if (currentcustomer.tablenumber == 3)
        {
            gameManager.table3taken = false;
        }
        if (currentcustomer.tablenumber == 4)
        {
            gameManager.table4taken = false;
        }
        gameManager.table1taken = false;
        gameManager.table3taken = false;
        gameManager.table2taken = false;
        gameManager.table4taken = false;
    }
   
}
