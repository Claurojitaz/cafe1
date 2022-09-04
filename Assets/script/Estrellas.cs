using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrellas : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    public int Calificacion;
    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player")
            {
                Calificacion += other.GetComponent<calificacion>().Calificacion;
            Debug.Log("uno");
            }
    }



    // Update is called once per frame
    //void Update()
          
    
}
