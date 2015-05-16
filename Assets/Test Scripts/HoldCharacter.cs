using UnityEngine;
using System.Collections;

public class HoldCharacter : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.parent = gameObject.transform;
            //Debug.Log("On Platform");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.transform.parent = null;
            //Debug.Log("Off Platform");
        }
    }
}
