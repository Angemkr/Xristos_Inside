using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DimensionsToggle : MonoBehaviour
{
    public GameObject Canvas_Dimensions;

    // Update is called once per frame
    void Update()
    {
        // Button A
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Canvas_Dimensions.gameObject.SetActive(true);
        }

        // Button B
        if (OVRInput.Get(OVRInput.Button.Two)) 
        {
            Canvas_Dimensions.gameObject.SetActive(false);
        }
    }
}
