using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement movement;



    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Play("oof");
            FindObjectOfType<GameManager>().EndGame();

        }

    }




}
