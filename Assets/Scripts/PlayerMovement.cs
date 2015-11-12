using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PlayerMovement : MonoBehaviour
{
    public Text test;
    public float speed;
    public void Update()
    {

        if (test.text == "up")
        {
            transform.Translate((Vector2.up) * speed);
        }
        else if(test.text == "down")
        {
            transform.Translate((Vector2.down) * speed);
        }
        else if (test.text == "left")
        {
            transform.Translate((Vector2.left) * speed);
        }
        else if (test.text == "right")
        {
            transform.Translate((Vector2.right) * speed);
        }
        else if (test.text == "north east")
        {
            transform.Translate((Vector2.up + Vector2.right) * speed);
        }
        else if (test.text == "south east")
        {
            transform.Translate((Vector2.down + Vector2.right) * speed);
        }
        else if (test.text == "north west")
        {
            transform.Translate((Vector2.up + Vector2.left) * speed);
        }
        else if (test.text == "south west")
        {
            transform.Translate((Vector2.down + Vector2.left) * speed);
        }


        /*
        if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.down + Vector2.right) * speed);
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.down + Vector2.left) * speed);
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.up + Vector2.left) * speed);
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.up + Vector2.right) * speed);
        }
        else
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * speed);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * speed);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * speed);
            }
            else if (Input.GetKey(KeyCode.X))
            {
                transform.Translate((Vector2.down + Vector2.right) * speed);
            }
        }
        */
    }
}
