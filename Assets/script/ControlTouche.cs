using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControlTouche : MonoBehaviour
{
    public Image fillAmount;
    public float totaltime;

    public Color32 newColor;
    float time = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Image>().color = newColor;
            fillAmount.gameObject.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag=="Player")
        {
            time += Time.deltaTime;
            fillAmount.transform.GetChild(0).GetComponent<Image>().fillAmount = time / totaltime;
            if (time>=totaltime)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            time = 0;
            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            fillAmount.gameObject.SetActive(false);
        }
    }
}
