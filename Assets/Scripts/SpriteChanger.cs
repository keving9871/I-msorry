using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour {
    public GameManager gameManager;

    public Sprite Sprite;
    public Sprite Highlighted;

   

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
            if (gameManager.Alcohols[1].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        if (this.gameObject.tag == "BottleFat")
        {
            if (gameManager.Alcohols[4].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        if (this.gameObject.tag == "Shot")
        {
            if (gameManager.Alcohols[2].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        if (this.gameObject.tag == "Glass")
        {
            if (gameManager.Alcohols[3].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Chicken")
        {
            if (gameManager.Foods[4].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "BB")
        {
            if (gameManager.Foods[2].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "BG")
        {
            if (gameManager.Foods[3].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Steak")
        {
            if (gameManager.Foods[1].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        
        else if (this.gameObject.tag == "Bertha")
        {
            if (gameManager.Prostitutes[1].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Amalia")
        {
            if (gameManager.Prostitutes[2].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Eleanor")
        {
            if (gameManager.Prostitutes[3].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Fannie")
        {
            if (gameManager.Prostitutes[4].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Mollie")
        {
            if (gameManager.Prostitutes[5].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Pearl")
        {
            if (gameManager.Prostitutes[6].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }
        else if (this.gameObject.tag == "Ai")
        {
            if (gameManager.Prostitutes[7].Highlighted == true)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Highlighted;
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sprite;
            }
        }

    }
}
