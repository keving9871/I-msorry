using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderShit : MonoBehaviour {

    public Customer currentcustomer;

    public CustomerOrderSystem COS;

    public GameManager gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

        if (currentcustomer.Drinkpreference == 1)
        {
            Invoke("OrderBottle", 1f);
        }
        if (currentcustomer.Drinkpreference == 2)
        {
            Invoke("OrderShot", 1f);
        }
        if (currentcustomer.Drinkpreference == 3)
        {
            Invoke("OrderGlass", 1f);
        }
        if (currentcustomer.Drinkpreference == 4)
        {
            Invoke("OrderBottleFat", 1f);
        }



      //  if(this.gameObject)
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
