using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextDayButton : MonoBehaviour {

    public GameManager gameManager;
    public void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }


    public void nextDay()
    {
       SceneManager.LoadScene("Saloon");
        gameManager.Restart();
    }
	
	
}
