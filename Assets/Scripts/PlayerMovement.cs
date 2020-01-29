using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        //rb.AddForce(0, 0, 500 * Time.deltaTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            forwardForce += 500;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            forwardForce -= 500;
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
