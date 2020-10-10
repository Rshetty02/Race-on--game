using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // public Vector3 offset = new Vector3(0,0,1);

    
    // public Transform obstacle;
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision other) {
        
        if(other.collider.tag == "Obstacle")
        {
            //playerMovement.enabled = false;
            //obstacle.position = obstacle.position + offset;

            //FindObjectOfType<GameManager>().Endgame();

        }


    }
}
