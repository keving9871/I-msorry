using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LedgerButton : MonoBehaviour {

    public Button ledger;
    bool isShowing;
    public GameObject ledgerBook;
 
    
	void Start ()
    {
        Button btn = ledger.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
    {
        isShowing = !isShowing;
        ledgerBook.SetActive(isShowing);
        this.gameObject.GetComponent<Image>().enabled = false;
    }
}
