using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Teleports the keycard away
    public void KeyCardTeleport()
    {
        //animate disapear
        Destroy(gameObject);
    }
}