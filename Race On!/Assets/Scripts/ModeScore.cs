using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour
{
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public static int CurrentScore;
    public int InternalScore;

    public GameObject ScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if(ModeSelection == 1){
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);


        }
        




    }

    // Update is called once per frame
    void Update()
    {
        InternalScore = CurrentScore;
        
            ScoreValue.GetComponent<Text>().text = "" + InternalScore;
        
    }
}
