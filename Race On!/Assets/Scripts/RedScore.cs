using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScore : MonoBehaviour
{

    void OnCollisionEnter(){
        ModeScore.CurrentScore = ModeScore.CurrentScore + 100;
        gameObject.SetActive(false);
    }
}
