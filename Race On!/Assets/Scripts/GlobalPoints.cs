using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalPoints : MonoBehaviour
{
    public int CashValue;
    public static int TotalCash;

    public GameObject CashDisplay;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<Text>().text = "Total Points :" + TotalCash;

        
        
    }
}
