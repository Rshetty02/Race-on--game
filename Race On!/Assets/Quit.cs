using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update


    public void quit(){
        Debug.Log("QUIT");
        Application.Quit();
    }

}
