using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int point;
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GrainCont"))
        {
            GrainController confiGrain = other.GetComponent<GrainController>();
            transform.SetParent(confiGrain.transform);
            confiGrain.point += point;
            confiGrain.suma += point;
            confiGrain.pointText.text = confiGrain.point.ToString();
            confiGrain.envioPuntos.score = confiGrain.point;
            confiGrain.Point();
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GrainCont"))
        {
            GrainController confiGrain = other.GetComponent<GrainController>();
            transform.parent = null;
            confiGrain.point -= other.GetComponent<Point>().point;
            confiGrain.suma -= point;
            confiGrain.pointText.text = confiGrain.point.ToString();
            confiGrain.envioPuntos.score =confiGrain.point;
            confiGrain.Point();
        }
    }
}
