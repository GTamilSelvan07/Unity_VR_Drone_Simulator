using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "player") {
           // collision is with the player.
           // get the player interface
           PlayerInterface player = collision.gameObject.GetComponent(typeof(PlayerInterface)) as PlayerInterface;
           if( player != null) {
               PowerUpObject obj = (this.gameObject.GetComponent(typeof(PowerUpObject)) as PowerUpObject);
               if( obj != null ){
                  obj.performPowerupOnPlayer(player);
               }
           }
           Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
