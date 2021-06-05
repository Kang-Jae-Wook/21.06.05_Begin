using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 100.0f, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce( 0, 0, 1.0f, ForceMode.Impulse);
        }
 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(0, 0, -1.0f, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(1.0f, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            body.AddForce(-1.0f, 0, 0, ForceMode.Impulse);
        }

        if(transform.position.y < -30.0f)
        {
            transform.position = new Vector3(0,3.0f,0);
            transform.rotation = Quaternion.identity;
        }

    }
}
