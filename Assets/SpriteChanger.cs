using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour {
    public GameManager gameManager;

    public Sprite BottleH;
    public Sprite Bottle;

    public Sprite Chicken;
    public Sprite ChickenH;

    public Sprite Steak;
    public Sprite SteakH;

    public Sprite BB;
    public Sprite BBH;

    public Sprite BG;
    public Sprite BGH;

    // Use this for initialization
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Bottle")
        {
            if (gameManager.Alcohols[2].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BottleH;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Bottle;
            }
        }
        else if (this.gameObject.tag == "Chicken")
        {
            if (gameManager.Foods[4].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = ChickenH;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Chicken;
            }
        }
        else if (this.gameObject.tag == "BB")
        {
            if (gameManager.Foods[2].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BBH;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BB;
            }
        }
        else if (this.gameObject.tag == "BG")
        {
            if (gameManager.Foods[3].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BGH;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BG;
            }
        }
        else if (this.gameObject.tag == "Steak")
        {
            if (gameManager.Foods[1].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SteakH;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Steak;
            }
        }
    }
}
