using UnityEngine;

public class CarMover : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 resetPosition;
    public float boundaryDistance = 20f; 

    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, resetPosition) > boundaryDistance)
        {
            transform.position = resetPosition;
        }
    }
}