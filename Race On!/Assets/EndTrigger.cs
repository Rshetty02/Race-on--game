using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameManager gameManager;
 private void OnTriggerEnter() {
     
     gameManager.Win();

 }


}
