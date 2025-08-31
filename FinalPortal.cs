using UnityEngine;
using UnityEngine.SceneManagement; //  change levels

public class FinalPortal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // check if Player
        if (other.CompareTag("Player"))
        {
            // get the CookieCollector script on the Player
            CookieCollector collector = other.GetComponent<CookieCollector>();

            if (collector != null && collector.cookieCount == 6)
            {
                // load the next scene in Build Index (main menu)
                 SceneManager.LoadScene(0);
            }
            else
            {
                Debug.Log("You need 6 cookies to pass!");
            }
        }
    }
}