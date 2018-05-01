using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitDown : MonoBehaviour {
    public GameObject Sitting;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("x");
        if (col.gameObject.name == "Table")
        {
            Debug.Log("y");
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting);
            Sitting.transform.Translate(-3.23f, -1.1f, 1);
        }
        if (col.gameObject.name == "Table 4")
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting);
            Sitting.transform.Translate(-2.67f, -3.31f, 1);
        }
        if (col.gameObject.name == "Table 3")
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting);
            Sitting.transform.Translate(1.6f, -3.31f, 1);
        }
        if (col.gameObject.name == "Table 2")
        {
            Destroy(this.gameObject);
            Instantiate<GameObject>(Sitting);
            Sitting.transform.Translate(1.86f, -1.1f, 1);
        }
    }
}
