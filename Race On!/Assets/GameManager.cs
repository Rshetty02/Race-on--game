
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject wonScreen;
    public bool gameHasEnded = false;
    public float restartDelay = 2f;


    public void Win(){

        Debug.Log("You Win!");
        wonScreen.SetActive(true);


    }

    public void Endgame(){


       if(gameHasEnded == false){
       Debug.Log("Game Over");
        gameHasEnded = true;
        Restart();
        //Invoke("Restart",restartDelay);
        Invoke("Restart()",restartDelay);
        
       }

    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

   }



}
