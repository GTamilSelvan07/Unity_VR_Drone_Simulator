using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPowerUp : MonoBehaviour, PowerUpObject
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    public void performPowerupOnPlayer(PlayerInterface player){
        BatteryPlayerBehaviour batteries = ((MonoBehaviour) player).gameObject.GetComponent(typeof(BatteryPlayerBehaviour)) as BatteryPlayerBehaviour;
        if ( batteries != null ){
            batteries.partCharge();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
