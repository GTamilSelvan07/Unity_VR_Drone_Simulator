using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseMaxSpeed : MonoBehaviour, PowerUpObject
{
    // Start is called before the first frame update
    public float strength;
    void Start()
    {
        
    }

    public void performPowerupOnPlayer(PlayerInterface player){
        player.setMaxSpeed(player.getMaxSpeed() + strength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
