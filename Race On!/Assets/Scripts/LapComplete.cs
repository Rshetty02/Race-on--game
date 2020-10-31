using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LapComplete : MonoBehaviour
{
    
    public GameObject milliObject;

    
    public GameObject secondObject;
    public int HighScore;
    public int CashValue;

    public GameObject minuteObject;
    public float RawTime;
    UnityADs iad = new UnityADs();
    private void Start() {
        
    }
    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if(LapTimeManager.RawTime<=RawTime){
        milliObject.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
        

        if(LapTimeManager.SecondCount<=9){
            secondObject.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount +".";
        }
        else{
            secondObject.GetComponent<Text>().text = "" + LapTimeManager.SecondCount+ ".";
        }
        
        if(LapTimeManager.MinuteCount<=9){
            minuteObject.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount +":";
        }
        else{
            minuteObject.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
        }
        }
        PlayerPrefs.SetInt("MinSave",LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave",LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave",LapTimeManager.MilliCount);
        PlayerPrefs.SetFloat("RawTime",LapTimeManager.RawTime);
        //GlobalPoints.TotalCash = ModeScore.CurrentScore;


        HighScore = PlayerPrefs.GetInt("HighScore") + ModeScore.CurrentScore;
        PlayerPrefs.SetInt("HighScore",HighScore);
        //CashValue  = GlobalPoints.TotalCash;
        //GlobalPoints.TotalCash = ModeScore.CurrentScore + GlobalPoints.TotalCash;

        
        

        //PlayerPrefs.SetInt("HighScore",CashValue);
        //Debug.Log(PlayerPrefs.GetInt("HighScore"));
        LapTimeManager.RawTime = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MinuteCount = 0;

        iad.DisplayInterstitialAD();
        
        SceneManager.LoadScene("trackselect");
    }
    }






}
