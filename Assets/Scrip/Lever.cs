using System.Collections;
using System.Collections.Generic;
using Unity.VRTemplate;
using UnityEngine;
using UnityEngine.UIElements;

public class Lever : MonoBehaviour
{
    public bool lightsOn;
    public Light[] lights;

    Lever leverObj;
    float LeverPosition;

    // Start is called before the first frame update
    void Start()
    {
        leverObj = GetComponent<Lever>();
        LeverPosition = leverObj.GetComponent<XRKnob>().m_Value;
    }

    // Update is called once per frame
    void Update()
    {
        if (LeverPosition == 0)
        {
            lightsOn = true;
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].intensity = 1;
                Debug.Log("Current Lever Pos: "+ LeverPosition);
            }
        }
        else if (LeverPosition == 1)
        {
            lightsOn = false;
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].intensity = 0;
            }
        }
    }
    public void LightsEnabled()
    {
        lightsOn = !lightsOn;
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = !lights[i].enabled;
        }
    }
}


