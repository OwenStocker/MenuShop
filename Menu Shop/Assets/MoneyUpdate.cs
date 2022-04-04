using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUpdate : MonoBehaviour
{

    public int pCash = 100;
    public Text CashUpdate;
    
    public void TextCall()
    {
        CashUpdate.text = "Penman Cash - $" + pCash.ToString ();
    }
    // Start is called before the first frame update
    void Start()
    {
        CashUpdate.text = "Penman Cash - $" + pCash.ToString ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
