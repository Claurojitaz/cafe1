using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrellas : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    public int Calificacion;
    public calificacion calificacionGeneral;
    public WebRequest datos;
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag ("Player"))
            {
                Debug.Log("uno");
                calificacionGeneral.Calificacion=Calificacion;
                calificacionGeneral.CalificaStar();
                datos = GameObject.Find("manager").GetComponent<WebRequest>();
                datos.DataLoadStruct();
            }
    }
        
}
