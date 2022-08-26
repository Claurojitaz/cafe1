using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GrainController : MonoBehaviour
{
    public int point;
    public TMP_Text pointText;
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// <param name="other">The other Collider involved in this collision.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grain"))
        {
            other.transform.SetParent(transform);
            point += other.GetComponent<Point>().point;
            pointText.text = point.ToString();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Grain"))
        {
            other.transform.parent=null;
            point -= other.GetComponent<Point>().point;
            pointText.text = point.ToString();
        }
    }

}
