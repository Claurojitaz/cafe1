using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manejescenas : MonoBehaviour
{
    public enum Levels {SampleScene=0, final=1 }

    public void CambiarNivel(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }

    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
    public void CambiarNivelStatic(Levels level)
    {
        SceneManager.LoadScene((int)level);
    }
}
