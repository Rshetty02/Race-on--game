using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{

    void start(){

        ModeScore.CurrentScore = 0;
    }
     void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            

            ModeScore.CurrentScore = ModeScore.CurrentScore + 100;
            gameObject.SetActive(false);
            
        }
     }
}
