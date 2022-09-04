using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public int suma;
    public GameObject arboles;
    public GameObject TextoTempo;
    public CronoTiempo canvasTime;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (suma==3)
        {
            arboles.SetActive(true);
            canvasTime.initial = true;
            TextoTempo.SetActive(true);
        }

    }
}
