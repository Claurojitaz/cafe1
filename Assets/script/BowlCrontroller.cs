using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlCrontroller : MonoBehaviour
{
    public GameObject pointBowl;
    public GameObject TextoTempo;
    //public GameObject TextoTempo;
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bowl"))
        {
            other.gameObject.transform.SetParent(pointBowl.transform);
            TextoTempo.SetActive(true);
        }
        
    }
}
