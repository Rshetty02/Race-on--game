using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
     public Transform zposplayer ;
     public float  initialpos;
    
    // Start is called before the first frame update
    void Start()
    {
     initialpos = zposplayer.position.z;
    }
   
  

    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = (zposplayer.position.z - initialpos).ToString("0");
    }
}
