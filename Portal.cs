using UnityEngine;
using UnityEngine.SceneManagement; //  change levels

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // check if player
        if (other.CompareTag("Player"))
        {
            // get  CookieCollector script on player
            CookieCollector collector = other.GetComponent<CookieCollector>();

            if (collector != null && collector.cookieCount == 6)
            {
                // load the next scene (lvl 2)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Debug.Log("You need 6 cookies to pass!");
            }
        }
    }
}