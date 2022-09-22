using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CronoTiempo : MonoBehaviour
{
    public float tiempoBtn;
    public float tiempo;
    public TMP_Text tiempotxt;
    public GameObject mensaje_final;
    public GameObject puntos1;
    public GameObject boton;
    public GameObject canvasTr;
    public GameObject coca;
    public bool initial;
    public WebRequest envioInfo;
    public bool envio;
    public AudioSource ramas;
    public AudioSource granos_caida;
    public GameObject arboles;
    public GameObject relleno;
    void Start()
    {
        int minutos = (int)tiempo / 60;
        int segundos = (int)tiempo % 60;
        string v = minutos.ToString() + ":" + segundos.ToString().PadLeft(2, '0');
        tiempotxt.text = v;
        envioInfo = GameObject.Find("manager").GetComponent<WebRequest>();
    }

    // Update is called once per frame
    void Update()
    {
        if (initial)
        {
            CalcularTiempo();
        }
        
        if (tiempo <= 0)
        {
            tiempotxt.text = 0 + ":" + 0;
            //SceneManager.LoadScene("final");
            mensaje_final.SetActive(true);
            puntos1.SetActive(false);
            coca.SetActive(false);
            arboles.SetActive(false);
            granos_caida.Play();
            if (envio)
            {
                envioInfo.DataLoadStruct();
            }
            envio = false;
            tiempoBtn -= Time.deltaTime;
            if (tiempoBtn<=0)
            {
                boton.SetActive(true);
            }
        }
        else
        {
            mensaje_final.SetActive(false);
            puntos1.SetActive(false);
            boton.SetActive(false);
        }
        if (tiempo<=28)
        {
            canvasTr.SetActive(false);
            ramas.Play();
        }
        if (tiempo==15)
        {
            ramas.Play();
        }
        if (tiempo == 7)
        {
            ramas.Play();
        }
        if (tiempo == 3)
        {
            ramas.Play();
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
