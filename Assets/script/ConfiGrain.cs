using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiGrain :MonoBehaviour //UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable 
{
    public Rigidbody rb;
    public GrainController grano;
    
    private void Update()
    {
    }
    public void Select()
    {
        rb.isKinematic = false;
        GetComponent<Point>().point = 1;
    }
    

}
