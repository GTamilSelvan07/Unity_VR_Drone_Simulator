using UnityEngine;
public class DronePlayer : MonoBehaviour
{
    public float maxSpeed = 5.0f;
    public int score = 0;
    public float getMaxSpeed()
    {
        return maxSpeed;
    }
    public void setMaxSpeed(float speed)
    {
        maxSpeed = speed;
    }
    public /*Score*/ void getScore()
    {
    }

    // Declare Flight Controller Variables
    public float forwardSpeed = 0.0f, strafeSpeed = 0.0f, hoverSpeed = 0.0f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;

    // Start is called before the first frame update
    void Start()
    {
        print("Drone Simualtion ");
    }

    public void Forward()
    {
        //Debug.Log("Forward Function Called");
        transform.position += transform.forward * Time.deltaTime * forwardSpeed;
    }
    public void Backward()
    {
        //Debug.Log("Backward Function Called");
        transform.position += transform.forward * Time.deltaTime * -forwardSpeed;
    }
    public void Right()
    {
        //Debug.Log("Right Function Called");
        transform.position += transform.right * Time.deltaTime * strafeSpeed;
    }
    public void Left()
    {
        //Debug.Log("Left Function Called");
        transform.position += transform.right * Time.deltaTime * -strafeSpeed;
    }
    public void Up()
    {
        //Debug.Log("Up Function Called");
        transform.position += transform.up * Time.deltaTime * hoverSpeed;
    }
    public void Down()
    {
        //Debug.Log("Down Function Called");
        transform.position += transform.up * Time.deltaTime * -hoverSpeed;
    }


    // Update is called once per frame
    void Update()
    {
        forwardSpeed = maxSpeed;
        strafeSpeed = maxSpeed;
        hoverSpeed = maxSpeed;
        //Debug.Log("forwardSpeed = "+forwardSpeed);
        //activeForwardSpeed = Input.GetAxisRaw("Vertical") * forwardSpeed;
        //activeStrafeSpeed = Input.GetAxisRaw("Horizontal") * strafeSpeed;
        //activeHoverSpeed = Input.GetAxisRaw("Hover") * hoverSpeed;
        //transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Pressed w ");
            Forward();

        }
        else if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Pressed s ");
            Backward();

        }
        else if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Pressed a ");
            Left();

        }
        else if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Pressed d  ");
            Right();

        }
        else if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Pressed space ");
            Up();

        }
        else if (Input.GetKey(KeyCode.LeftAlt))
        {
            //Debug.Log("Pressed left alt  ");
            Down();

        }
    }
}
