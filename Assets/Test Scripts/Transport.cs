using UnityEngine;
using System.Collections;

public class Transport : MonoBehaviour
{
    // Declaration of private reference veribles
    private Collider playerCol;
    private Vector3 destinationPos;

    // Awake is called when the script instance is being loaded
    public void Awake()
    {
        playerCol = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider>();
        destinationPos = GameObject.FindGameObjectWithTag("DestOne").transform.position;
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    public void OnTriggerEnter(Collider other)
    {
        
        if (other = playerCol)
        {
            other.transform.position = destinationPos;
        }
    }
}
