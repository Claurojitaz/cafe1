using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Bowl"))
        {
            other.transform.parent=this.gameObject.transform;
        }
    }
}
