using UnityEngine.SceneManagement;
using UnityEngine;

public class Start : MonoBehaviour
{
    
    public void startGame(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    

}
