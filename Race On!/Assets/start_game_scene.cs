using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game_scene : MonoBehaviour
{
    public static int track;

    public int scoresub;
    // Start game
    public void startgameday(){
        SceneManager.LoadScene("Level02");
        track = 1;
        
        
    }

    public void startgamenight(){
        if(PlayerPrefs.GetInt("HighScore") >= 200 ){
        SceneManager.LoadScene("Level02");
        track = 2; 
        scoresub = PlayerPrefs.GetInt("HighScore") - 200;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void startgameovercast(){
        if(PlayerPrefs.GetInt("HighScore") >= 200 ){
        SceneManager.LoadScene("Level02");
        track = 3;
        scoresub = PlayerPrefs.GetInt("HighScore") - 200;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }

    public void startgameevening(){
        if(PlayerPrefs.GetInt("HighScore") >= 200 ){
        SceneManager.LoadScene("Level02");
        track = 4;
        scoresub = PlayerPrefs.GetInt("HighScore") - 200;
        PlayerPrefs.SetInt("HighScore",scoresub);
        }
    }



    // track select
    public void trackselect(){
        SceneManager.LoadScene("trackselect");
    } 

    public void mainmenu(){
        SceneManager.LoadScene("Main Menu");

    }

    public void mountainbackroad(){
        SceneManager.LoadScene("Level02");

    }

    public void credits(){
        SceneManager.LoadScene("End Credits");

    }

}
