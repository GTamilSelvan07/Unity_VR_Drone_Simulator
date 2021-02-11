using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    float maxCharge = 100.0f;
    float juce = 100.0f;
    float delta = 0.001f;
    float chargeAmount = 25.0f;
    void Start()
    {
        
    }

    public bool isEmpty() {
        return ( juce == 0);
    }

    public void partCharge() {
       float newCharge = juce+chargeAmount;
       if (newCharge < maxCharge) {
           juce = newCharge;
       } else {
           juce = maxCharge;
       }
    }

    // Update is called once per frame
    void Update()
    {
        float newCharge = juce - delta;
        if ( newCharge > 0) {
            juce = newCharge;
        } else {
            juce = 0;
        }
    }
}
