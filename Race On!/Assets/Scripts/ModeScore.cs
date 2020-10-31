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
    public int HighScore;

    public GameObject ScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        InternalScore = CurrentScore;
        
            ScoreValue.GetComponent<Text>().text = "" + InternalScore;
            //HighScore = PlayerPrefs.GetInt("HighScore") + InternalScore;
            //PlayerPrefs.SetInt("HighScore",HighScore);
            //GlobalPoints.TotalCash = ModeScore.CurrentScore + GlobalPoints.TotalCash;
        
    }
}
