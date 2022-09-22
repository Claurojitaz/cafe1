using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int Calificacion;
    public void calificar()
    {
     Calificacion += GetComponent<calificacion>().Calificacion;
     Debug.Log("uno");
    }
    public void probar()
    {
        Debug.Log("ingreso");
    }
}
