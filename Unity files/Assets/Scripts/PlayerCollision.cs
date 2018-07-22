using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obsticle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }
    }

}
