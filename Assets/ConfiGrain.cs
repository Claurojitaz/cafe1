using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfiGrain :MonoBehaviour //UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable 
{
    public Rigidbody rb;
    private void Update()
    {
    }
    public void Select()
    {
        rb.isKinematic = false;
    }
    

}
