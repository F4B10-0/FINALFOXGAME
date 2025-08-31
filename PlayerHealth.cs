using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            lives--;
            Debug.Log("Ouch! Lives left: " + lives);

            if (lives <= 0)
            {
                Debug.Log("Game Over!");
                
            }
        }
    }
}