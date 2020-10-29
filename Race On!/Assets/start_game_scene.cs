using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game_scene : MonoBehaviour
{
    public static int track;
    // Start game
    public void startgameday(){
        SceneManager.LoadScene("Level02");
        track = 1;
    }

    public void startgamenight(){
        SceneManager.LoadScene("Level02");
        track = 2;
    }

    public void startgameovercast(){
        SceneManager.LoadScene("Level02");
        track = 3;
    }

    public void startgameevening(){
        SceneManager.LoadScene("Level02");
        track = 4;
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
