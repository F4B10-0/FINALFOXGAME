using UnityEngine;

public class CookieCollector : MonoBehaviour
{
    public int cookieCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cookie"))
        {
            Destroy(other.gameObject); 
            cookieCount++; 
            Debug.Log("Snacks collected: " + cookieCount);
        }
    }
}