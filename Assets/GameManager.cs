using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Prostitute[] Prostitutes;

    public Sprite Berthas; //1
    public Sprite Amalias; //2
    public Sprite Eleanors; //3
    public Sprite Fannies; //4
    public Sprite Mollies; //5
    public Sprite Pearls; //6
    public Sprite Ais; //7
    public Sprite Vanessas; //8
    public Sprite Julias; //9
    public Sprite Alices; //10

    public Alcohol[] Alcohols;

    public Sprite Gins; //1
    public Sprite Liquors;//2
    public Sprite Whiskeys;//3
    public Sprite Bourbons;//4







    // Use this for initialization
    void Start () {
        //Prostitute(Sprite sprite, string name, int preference)
        Prostitute Bertha = new Prostitute(Berthas, 1);
        Prostitute Amalia = new Prostitute(Amalias, 2);
        Prostitute Eleanor = new Prostitute(Eleanors, 3);
        Prostitute Fannie = new Prostitute(Fannies, 4);
        Prostitute Mollie = new Prostitute(Mollies, 5);
        Prostitute Pearl = new Prostitute(Pearls, 6);
        Prostitute Ai = new Prostitute(Ais, 7);
        Prostitute Vanessa = new Prostitute(Vanessas, 8);
        Prostitute Julia = new Prostitute(Julias, 9);
        Prostitute Alice = new Prostitute(Alices, 10);

        Prostitutes = new Prostitute[11];

        Prostitutes[1] = Bertha;
        Prostitutes[2] = Amalia;
        Prostitutes[3] = Eleanor;
        Prostitutes[4] = Fannie;
        Prostitutes[5] = Mollie;
        Prostitutes[6] = Pearl;
        Prostitutes[7] = Ai;
        Prostitutes[8] = Vanessa;
        Prostitutes[9] = Julia;
        Prostitutes[10] = Alice;

        //Alcohol(Sprite sprite, string name, int preference)
        Alcohol Gin = new Alcohol(Gins, 1);
        Alcohol Liquor = new Alcohol(Liquors, 2);
        Alcohol Whiskey = new Alcohol(Whiskeys, 3);
        Alcohol Bourbon = new Alcohol(Bourbons, 4);

        Alcohols = new Alcohol[5];

        Alcohols[1] = Gin;
        Alcohols[2] = Liquor;
        Alcohols[3] = Whiskey;
        Alcohols[4] = Bourbon;

        // Food(Sprite sprite, int preference)


        // Customer(Sprite sprite, int food, int drink, int women)


    }

    // Update is called once per frame
    void Update () {
		
	}
}
