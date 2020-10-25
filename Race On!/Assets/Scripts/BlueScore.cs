using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour
{

    void OnCollisionEnter() {
        ModeScore.CurrentScore = ModeScore.CurrentScore + 50;
        gameObject.SetActive(false);
    }
}
