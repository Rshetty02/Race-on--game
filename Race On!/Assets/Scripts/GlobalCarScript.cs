using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCarScript : MonoBehaviour
{

    public static int CarType;
    public int scoresub;

    public GameObject AICarWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RedCar(){
        if(PlayerPrefs.GetInt("HighScore") >= 100 ){
        CarType =1;
        AICarWindow.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 100;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void BlueCar(){
        if(PlayerPrefs.GetInt("HighScore") >= 100 ){
        CarType = 2;
        AICarWindow.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 100;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void BlackCar(){
        if(PlayerPrefs.GetInt("HighScore") >= 100 ){
        CarType = 3;
        AICarWindow.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 100;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void GreenCar(){
        CarType = 4;
        AICarWindow.SetActive(true);
    }

    
}
