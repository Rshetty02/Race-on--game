
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    
    public Transform playerPosition;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
       
       transform.position = playerPosition.position + offset;


    }
}
