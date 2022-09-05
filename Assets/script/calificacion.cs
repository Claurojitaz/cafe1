using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calificacion : MonoBehaviour
{
    public int Calificacion;
    public Image estrella1;
    public Image estrella2;
    public Image estrella3;
    public Image estrella4;
    public Image estrella5;

    /// Update is called every frame, if the MonoBehaviour is enabled.
    private void Update()
    {

    }
    public void CalificaStar()
    {
                switch (Calificacion)
        {
            case 1:
                estrella1.fillAmount=1;
                break;
            case 2:
                estrella1.fillAmount=1;
                estrella2.fillAmount=1;
                break;
            case 3:
                estrella1.fillAmount=1;
                estrella2.fillAmount=1;
                estrella3.fillAmount=1;
                break;
            case 4:
                estrella1.fillAmount=1;
                estrella2.fillAmount=1;
                estrella3.fillAmount=1;
                estrella4.fillAmount=1;
                break;
            case 5:
                estrella1.fillAmount=1;
                estrella2.fillAmount=1;
                estrella3.fillAmount=1;
                estrella4.fillAmount=1;
                estrella5.fillAmount=1;
                break;
        }
    }
}
