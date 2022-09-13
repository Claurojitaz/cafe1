using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiGrain :MonoBehaviour //UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable 
{
    public Rigidbody rb;
    
    public void Select()
    {
        rb.isKinematic = false;
        Point poinst = GetComponent<Point>();
        poinst.enabled = true;
        
    }
    

}
