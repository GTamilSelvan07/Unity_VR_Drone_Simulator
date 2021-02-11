using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenItems : MonoBehaviour
{
    public Rigidbody prefab;    //TODO: change to powerup or item class when class exists
    private Vector3 spawnPos;
    private Vector3 velocity;
    private const float LIFETIME = 5.0f;
    private const float SIZE = 40.0f;
    private const float SIZE_RATE = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = this.transform.position;
        spawnPos += this.transform.forward * 50; //will be 50m away 
        InvokeRepeating("createPowerUp", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        spawnPos = this.transform.position;
        spawnPos += this.transform.forward * 50; //will be 50m away 
    }

    void createPowerUp()
    {
        Quaternion rotate = Quaternion.Euler(Random.Range(-15.0f, 15.0f), Random.Range(-15.0f, 15.0f),0);
        Rigidbody powerUp = Instantiate(prefab, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.Euler(0.0f, 90.0f, 0.0f));
        powerUp.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        powerUp.velocity = rotate * (new Vector3(0f,0f,Random.Range(-20.0f, -10.0f)));
        StartCoroutine(grow(powerUp.gameObject));
        StartCoroutine(shrink(powerUp.gameObject));
        StartCoroutine(destroyItem(powerUp.gameObject));
    }

    IEnumerator grow(GameObject obj)
    {
        for (float s = 0; s <= SIZE; s += SIZE_RATE)
        {
            if (obj != null)
            {
                obj.transform.localScale = new Vector3(s, s, s);
            }
            yield return null;
        }
    }

    IEnumerator shrink(GameObject obj)
    {
        if (obj != null)
        {
            yield return new WaitForSeconds(LIFETIME - 0.5f);
            for (float s = SIZE; s >= 0.0f; s -= SIZE_RATE)
            {
                if (obj != null)
                {
                    obj.transform.localScale = new Vector3(s, s, s);
                }
                yield return null;
            }
        }
    }

    IEnumerator destroyItem(GameObject obj)
    {
        yield return new WaitForSeconds(LIFETIME);
        if(obj != null)
        {
            Destroy(obj);
        }
    }
}
