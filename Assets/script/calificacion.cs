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
    public WebRequest request;
    /// Update is called every frame, if the MonoBehaviour is enabled.
    private void Update()
    {

    }
    public void CalificaStar()
    {
                switch (Calificacion)
        {
            case 1:
                if (estrella1.fillAmount==0)
                {
                    estrella1.fillAmount = 1;
                }
                else
                {
                    estrella5.fillAmount = 0;
                    estrella4.fillAmount = 0;
                    estrella3.fillAmount = 0;
                    estrella2.fillAmount = 0;
                    estrella1.fillAmount = 0;
                }
                request.calificacion = Calificacion;
                break;
            case 2:
                if (estrella2.fillAmount == 0)
                {
                    estrella2.fillAmount = 1;
                    estrella1.fillAmount = 1;
                }
                else
                {
                    estrella5.fillAmount = 0;
                    estrella4.fillAmount = 0;
                    estrella3.fillAmount = 0;
                    estrella2.fillAmount = 0;
                    estrella1.fillAmount = 0;
                }
                request.calificacion = Calificacion;
                break;
            case 3:
                if (estrella3.fillAmount == 0)
                {
                    estrella3.fillAmount = 1;
                    estrella2.fillAmount = 1;
                    estrella1.fillAmount = 1;
                }
                else
                {

                    estrella5.fillAmount = 0;
                    estrella4.fillAmount = 0;
                    estrella3.fillAmount = 0;
                    estrella2.fillAmount = 0;
                    estrella1.fillAmount = 0;

                }
                request.calificacion = Calificacion;
                break;
            case 4:
                if (estrella4.fillAmount == 0)
                {
                    estrella4.fillAmount = 1;
                    estrella3.fillAmount = 1;
                    estrella2.fillAmount = 1;
                    estrella1.fillAmount = 1;
                }
                else
                {
                    estrella5.fillAmount = 0;
                    estrella4.fillAmount = 0;
                    estrella3.fillAmount = 0;
                    estrella2.fillAmount = 0;
                    estrella1.fillAmount = 0;

                }
                request.calificacion = Calificacion;
                break;
            case 5:
                if (estrella5.fillAmount == 0)
                {
                    estrella5.fillAmount = 1;
                    estrella4.fillAmount = 1;
                    estrella3.fillAmount = 1;
                    estrella2.fillAmount = 1;
                    estrella1.fillAmount = 1;
                }
                else
                {
                    estrella5.fillAmount = 0;
                    estrella4.fillAmount = 0;
                    estrella3.fillAmount = 0;
                    estrella2.fillAmount = 0;
                    estrella1.fillAmount = 0;

                }
                request.calificacion = Calificacion;
                break;
        }
    }
}
