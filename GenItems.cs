using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenItems : MonoBehaviour
{
    public Rigidbody prefab;    //TODO: change to powerup or item class when class exists
    private Vector3 spawnPos;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = this.transform.position;
        spawnPos.z += 50; //will be 50m away 
        InvokeRepeating("createPowerUp", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        spawnPos = this.transform.position;
        spawnPos.z += 50; //will be 50m away 
    }

    void createPowerUp()
    {
        Quaternion rotate = Quaternion.Euler(Random.Range(-15.0f, 15.0f), Random.Range(-15.0f, 15.0f),0);
        Rigidbody powerUp = Instantiate(prefab, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
        powerUp.velocity = rotate * (new Vector3(0f,0f,Random.Range(-20.0f, -10.0f)));
        Destroy(powerUp.gameObject, 5.0f);
    }
}
