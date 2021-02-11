using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMaxSpeed : PowerUpObject {
    // Start is called before the first frame update
    public float strength = 5.0f;
    void Start()
    {
        
    }

    public override void performPowerupOnPlayer(DronePlayer player){
        player.setMaxSpeed(player.getMaxSpeed() + strength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
