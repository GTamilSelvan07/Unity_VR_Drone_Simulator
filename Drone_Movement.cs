using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Movement : MonoBehaviour
{
    // Declare Flight Controller Variables
    public float forwardSpeed = 25f, strafeSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;

    // Start is called before the first frame update
    void Start()
    {
        print("Drone Simualtion ");
    }

    public void Forward()
    {
        Debug.Log("Forward Function Called");
        transform.position += transform.forward * Time.deltaTime * forwardSpeed;
    }
    public void Backward()
    {
        Debug.Log("Backward Function Called");
        transform.position += transform.forward * Time.deltaTime * -forwardSpeed;
    }
    public void Right()
    {
        Debug.Log("Right Function Called");
        transform.position += transform.right * Time.deltaTime * strafeSpeed;
    }
    public void Left()
    {
        Debug.Log("Left Function Called");
        transform.position += transform.right * Time.deltaTime * -strafeSpeed;
    }
    public void Up()
    {
        Debug.Log("Up Function Called");
        transform.position += transform.up * Time.deltaTime * hoverSpeed;
    }
    public void Down()
    {
        Debug.Log("Down Function Called");
        transform.position += transform.up * Time.deltaTime * -hoverSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        //activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        //activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        //activeHoverSpeed = Input.GetAxisRaw("Hover") * hoverSpeed;
        //transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Pressed w ");
            Forward();

        }
        else if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Pressed s ");
            Backward();

        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed a ");
            Left();

        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed d  ");
            Right();

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed space ");
            Up();

        }
        else if (Input.GetKey(KeyCode.LeftAlt))
        {
            Debug.Log("Pressed left alt  ");
            Down();

        }
    }
}

