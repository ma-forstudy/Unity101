using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float SP = 0.01f;
    float X, Y, Z;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*print("Hello");
        print(transform.position);*/

        //Input.GetKeyDown(KeyCode.W)

        /*if (Input.GetKeyDown(KeyCode.UpArrow)) //if (Input.GetKeyDown(KeyCode.W) == true)
        {
            //print("W");

            transform.position = new Vector3(0, 2, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(0, -2, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(2, 0, 0);
        }*/

        X = transform.position.x;
        Y = transform.position.y;
        Z = transform.position.z;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(X, Y + SP, Z);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(X, Y - SP, Z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(X - SP, Y, Z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(X + SP, Y, Z);
        }

    }
}
