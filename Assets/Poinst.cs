using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poinst : MonoBehaviour
{
    public int point;
    public void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
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
}
