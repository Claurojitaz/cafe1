using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecBowl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Selectable()
    {
        GameObject gameObjectTrans= GameObject.Find("PointBowl");
        transform.SetParent(gameObjectTrans.transform);
    }
}
