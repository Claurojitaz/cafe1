using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GrainController : MonoBehaviour
{
    public int point;
    public TMP_Text pointText;
    public int suma;
    public GameObject arboles;
    public GameObject TextoTempo;
    public GameObject ejemplo;
    public GameObject TextTutorial;
    public GameObject TextJugar;
    public GameObject canvasTr;
    public CronoTiempo canvasTime;
    public WebRequest envioPuntos;
    public bool conteo;

    void Start()
    {
        envioPuntos = GameObject.Find("manager").GetComponent<WebRequest>();
    }
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// <param name="other">The other Collider involved in this collision.</param>
    public void Point(GameObject other)
    {
        

        if (suma == 3)
        {
            arboles.SetActive(true);
            canvasTime.initial = true;
            TextoTempo.SetActive(true);
            ejemplo.SetActive(false);
            TextTutorial.SetActive(false);
            TextJugar.SetActive(true);
            canvasTr.SetActive(true);
        }
    }
    


}
