using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int point;
    private void Start()
    {
        
    }

    private void on (Collider other)
    {
        if (other.gameObject.CompareTag("Bowl"))
        {
            GrainController confiGrain = other.GetComponent<GrainController>();
            confiGrain.transform.SetParent(transform);
            confiGrain.point += point;
            confiGrain.suma = point;
            confiGrain.pointText.text = point.ToString();
            confiGrain.envioPuntos.score = point;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bowl"))
        {
            GrainController confiGrain = other.GetComponent<GrainController>();
            confiGrain.transform.parent = null;
            confiGrain.point -= other.GetComponent<Point>().point;
            confiGrain.pointText.text = point.ToString();
            confiGrain.envioPuntos.score = point;
        }
    }
}
