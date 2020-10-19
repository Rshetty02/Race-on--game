using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{public static int MinuteCount;
	public static int SecondCount;
	public static float MilliCount;
	public static string MilliDisplay;

	public static float RawTime;

	
	public GameObject MinuteBox;
	public GameObject SecondBox;
	public GameObject MilliBox;
	

	void Update () {
		MilliCount += Time.deltaTime * 10;
		RawTime += Time.deltaTime;
		MilliDisplay = MilliCount.ToString ("F0");
		
		MilliBox.GetComponent<Text> ().text = "" + MilliDisplay;

		if (MilliCount >= 10) {
			MilliCount = 0;
			SecondCount += 1;
		}

		if (SecondCount <= 9) {
			SecondBox.GetComponent<Text> ().text = "0" + SecondCount + ".";
		} else {
			SecondBox.GetComponent<Text> ().text = "" + SecondCount + ".";
		}

		if (SecondCount >= 60) {
			SecondCount = 0;
			MinuteCount += 1;
		}

		if (MinuteCount <= 9) {
			MinuteBox.GetComponent<Text> ().text = "0" + MinuteCount + ":";
		} else {
			MinuteBox.GetComponent<Text> ().text = "" + MinuteCount + ":";
		}
		
	}
// {
//     public static float milliDisplay = 0.0f;
//     public static int secondDisplay;
//     public static int minuteDisplay;

//     public static string milliString;
//     public GameObject milliBox;
//     public GameObject secondBox;
//     public GameObject minuteBox;

   
//     // Update is called once per frame
//     void FixedUpdate()
//     {
//         milliDisplay =+ Time.deltaTime * 100;
        
//         milliString = milliDisplay.ToString("F0");
//         milliBox.GetComponent<Text>().text = "" + milliString ;


//         if(milliDisplay>=10){

//             milliDisplay = 0;
//             secondDisplay =+1;

//         }
        
//         if(secondDisplay <=9){
//         secondBox.GetComponent<Text>().text = "0" + secondDisplay + "."; 
//         }
//         else{
//         secondBox.GetComponent<Text>().text = "" + secondDisplay + ".";   
//         }

//         if(secondDisplay>=60){
//             secondDisplay = 0;
//             minuteDisplay =+ 1;
//         }

//         if(minuteDisplay <=9){
//             minuteBox.GetComponent<Text>().text = "0" + minuteDisplay + ":";
//         }
//         else{
//            minuteBox.GetComponent<Text>().text = "" + minuteDisplay + ":"; 
//         }

//         Debug.Log(milliDisplay.ToString());
//         Debug.Log(minuteDisplay.ToString());
//         Debug.Log(secondDisplay.ToString());
        
//     }

}
