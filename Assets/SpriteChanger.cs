using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour {
    public GameManager gameManager;

    public Sprite BottleH;
    public Sprite Bottle;

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
    }
}
