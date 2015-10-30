using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.down + Vector2.right) * speed);
            //   transform.Translate(Vector2.right * speed);
        }
        else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.down + Vector2.left) * speed);
            //   transform.Translate(Vector2.right * speed);
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.up + Vector2.left) * speed);
            //   transform.Translate(Vector2.right * speed);
        }
        else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.up + Vector2.right) * speed);
            //   transform.Translate(Vector2.right * speed);
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
                //   transform.Translate(Vector2.right * speed);
            }
        }
    }
}
