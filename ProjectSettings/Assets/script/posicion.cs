using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicion : MonoBehaviour
{
    public GameObject arbol1;
    public GameObject arbol2;
    public GameObject arbol3;
    public GameObject arbol4;
    public GameObject arbol5;
    public GameObject arbol6;
    public Transform posicion1;
    public Transform posicion2;
    public Transform posicion3;
    public Transform posicion4;
    public Transform posicion5;
    public Transform posicion6;
    public Transform posicion7;
    //public Transform posicion8;
    void Start()
    {
        int n = Random.Range(1, 3);
        if (n==1)
        {
            arbol1.transform.position = posicion1.transform.position;
            arbol2.transform.position = posicion2.transform.position;
            arbol3.transform.position = posicion3.transform.position;
            arbol4.transform.position = posicion4.transform.position;
            arbol5.transform.position = posicion5.transform.position;
            arbol6.transform.position = posicion6.transform.position;
        }
        if (n == 2)
        {
            arbol1.transform.position = posicion2.transform.position;
            arbol2.transform.position = posicion1.transform.position;
            arbol3.transform.position = posicion6.transform.position;
            arbol4.transform.position = posicion5.transform.position;
            arbol5.transform.position = posicion3.transform.position;
            arbol6.transform.position = posicion7.transform.position;
        }
        if (n == 3)
        {
            arbol1.transform.position = posicion6.transform.position;
            arbol2.transform.position = posicion5.transform.position;
            arbol3.transform.position = posicion4.transform.position;
            arbol4.transform.position = posicion3.transform.position;
            arbol5.transform.position = posicion2.transform.position;
            arbol6.transform.position = posicion1.transform.position;
        }
    }
     
    void Update()
    {        
    }
   
}
