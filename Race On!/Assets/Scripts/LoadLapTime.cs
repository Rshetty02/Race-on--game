using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinCount;
    public int SecCount;
    public float millicount;
    public GameObject MiniDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;


    // Start is called before the first frame update
    void Start()
    {
        MinCount = PlayerPrefs.GetInt("MinSave");

        SecCount = PlayerPrefs.GetInt("SecSave");

        millicount = PlayerPrefs.GetFloat("MilliSave");

        MiniDisplay.GetComponent<Text>().text = "" + MinCount + ":";

        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";

        MilliDisplay.GetComponent<Text>().text = "" + millicount;



    }

    
}
