using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapComplete : MonoBehaviour
{
    
    public GameObject milliObject;

    public GameObject secondObject;

    public GameObject minuteObject;


    public void OnTriggerEnter() {

        
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

        PlayerPrefs.SetInt("MinSave",LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave",LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave",LapTimeManager.MilliCount);


        LapTimeManager.MilliCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MinuteCount = 0;

    }






}
