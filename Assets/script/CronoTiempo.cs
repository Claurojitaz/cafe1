using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CronoTiempo : MonoBehaviour
{
    public float tiempoBtn=1000;
    public float tiempo;
    public TMP_Text tiempotxt;
    public GameObject mensaje_final;
    public GameObject puntos1;
    public GameObject boton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalcularTiempo();
        if (tiempo <= 0)
        {
            tiempotxt.text = 0 + ":" + 0;
            //SceneManager.LoadScene("final");
            mensaje_final.SetActive(true);
            puntos1.SetActive(false);
            tiempoBtn -= Time.deltaTime;
            if (tiempoBtn<=0)
            {
                boton.SetActive(true);
            }
        }
        else
        {
            mensaje_final.SetActive(false);
            puntos1.SetActive(true);
            boton.SetActive(false);
        }
    }

    void CalcularTiempo()
    {
        tiempo -= Time.deltaTime;
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        tiempotxt.text = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');
    }
}
