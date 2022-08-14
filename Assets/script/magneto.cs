using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneto : MonoBehaviour
{
    public float forceFactor = 2000f;

    List<Rigidbody> rgcoca = new List<Rigidbody>();

    Transform magnetP;
    // Start is called before the first frame update
    void Start()
    {
        magnetP = GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        foreach (Rigidbody rgcoca in rgcoca)
        {
            rgcoca.AddForce((magnetP.position - rgcoca.position) * forceFactor * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coca"))
        {
            rgcoca.Add(other.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("coca"))
        {
            rgcoca.Remove(other.GetComponent<Rigidbody>());
        }
    }

}
