using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{


    public void nextLevel(){

        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);


    }
}
