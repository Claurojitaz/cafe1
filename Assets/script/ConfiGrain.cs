using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ConfiGrain :MonoBehaviour //UnityEngine.XR.Interaction.Toolkit.XRGrabInteractable 
{
    public Rigidbody rb;
    public SphereCollider bocCollider;
    private void Start()
    {
        bocCollider = GetComponent<SphereCollider>();

    }

    public void Select()
    {
        Point poinst = GetComponent<Point>();
        poinst.enabled = true;
        rb.isKinematic = false;
        GrainController confiGrain = GameObject.Find("TzaMod2 Variant").GetComponent<GrainController>();
        transform.SetParent(confiGrain.transform);
        confiGrain.point +=poinst.point;
        confiGrain.suma +=poinst.point;
        confiGrain.pointText.text = confiGrain.point.ToString();
        confiGrain.envioPuntos.score = confiGrain.point;
        confiGrain.Point();
    }
    

}
