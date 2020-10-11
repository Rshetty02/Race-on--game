using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GameObject GetReady;
    public GameObject GoAudio;
    public GameObject Laptime;
    public GameObject CountDown;
    public GameObject CarControls;
    public GameObject AICarControl;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart(){

        yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text> ().text = "3";
        GetReady.SetActive(true);
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GetReady.SetActive(false);
        CountDown.GetComponent<Text> ().text = "2";
        GetReady.SetActive(true);
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GetReady.SetActive(false);
        CountDown.GetComponent<Text> ().text = "1";
        GetReady.SetActive(true);
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown.SetActive(false);
        GetReady.SetActive(false);

        Laptime.SetActive(true);
        GoAudio.SetActive(true);
        CarControls.GetComponent<PlayerMovement>().enabled = true;
        
        

    }
}
