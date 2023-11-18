using System.Collections;
using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction;

public class Lever : MonoBehaviour
{
    public bool lightsOn = false;
    public Light[] lights;

    public XRLever lever;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = (lever.value ? true : false);
            
        }
    }
    public void LightsEnabled()
    {
        lightsOn = lever.value ? true : false;
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = !lights[i].enabled;
        }
        Debug.Log("Current Lever Pos: " + lightsOn);
    }
}


