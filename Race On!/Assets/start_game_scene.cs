using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_game_scene : MonoBehaviour
{
    // Start game
    public void startgame(){
        SceneManager.LoadScene("Level02");

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
