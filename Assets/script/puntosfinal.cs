using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntosfinal : MonoBehaviour
{
    public TMP_Text valor_final;
    public TMP_Text dato; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dato.text = valor_final.text;
    }
}
