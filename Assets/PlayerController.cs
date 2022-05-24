using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float zSpeed;
    public float rotationSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, zSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -zSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
            transform.Rotate(0, rotationSpeed, 0);
        }

    }
}
