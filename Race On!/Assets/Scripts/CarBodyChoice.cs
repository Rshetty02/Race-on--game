using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBodyChoice : MonoBehaviour
{

    public GameObject RedCar;

    public GameObject BlueCar;

    public GameObject GreenCar;
    public GameObject BlackCar;

    public int CarImport;

    public int scoresub;

    // Start is called before the first frame update
    void Start()
    {
        CarImport = GlobalCarScript.CarType;

        if(CarImport == 1){
            if(PlayerPrefs.GetInt("HighScore") >= 100 ){
            RedCar.SetActive(true);
            scoresub = PlayerPrefs.GetInt("HighScore") - 100;
            PlayerPrefs.SetInt("HighScore",scoresub);
            }
        }
        else if(CarImport == 2){
            if(PlayerPrefs.GetInt("HighScore") >= 100 ){
            BlueCar.SetActive(true);
            scoresub = PlayerPrefs.GetInt("HighScore") - 100;
            PlayerPrefs.SetInt("HighScore",scoresub);
            }
        }
        else if(CarImport == 3){
            if(PlayerPrefs.GetInt("HighScore") >= 100 ){
            BlackCar.SetActive(true);
            scoresub = PlayerPrefs.GetInt("HighScore") - 100;
            PlayerPrefs.SetInt("HighScore",scoresub);
            }
        }
        else{
            
            GreenCar.SetActive(true);
        }
    }

    
}
