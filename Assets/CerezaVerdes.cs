using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CerezaVerdes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).transform.localPosition = new Vector3(0.0029f, 0.0106f, -0.0398f);
        GetComponent<XRGrabInteractable>().attachTransform = transform.GetChild(0).transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
