using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player movement;
    void OnCollisionEnter(Collision collisinInfo) 
    {
        if(collisinInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false ;
            FindObjectOfType<GameManager1>().EndGame();

        }
    }
}
