using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoofAICars : MonoBehaviour
{

    public static int NoOfAICarsvar;

    public GameObject TrackSelect;

    public int scoresub;

    // Start is called before the first frame update
    public void OneAICar(){

        NoOfAICarsvar = 1;
        TrackSelect.SetActive(true);
    }


    public void ThreeAICars(){
        if(PlayerPrefs.GetInt("HighScore") >= 200 ){
        NoOfAICarsvar = 3;
        TrackSelect.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 200;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void SevenAICars(){
        if(PlayerPrefs.GetInt("HighScore") >= 500 ){
        NoOfAICarsvar = 7;
        TrackSelect.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 500;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void NineAICars(){
        if(PlayerPrefs.GetInt("HighScore") >= 600 ){
        NoOfAICarsvar = 9;
        TrackSelect.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 600;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void ElevenAICars(){
        if(PlayerPrefs.GetInt("HighScore") >= 700 ){
        NoOfAICarsvar = 11;
        TrackSelect.SetActive(true);
        scoresub = PlayerPrefs.GetInt("HighScore") - 700;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }


}
