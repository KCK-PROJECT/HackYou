using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewPlayerMovement : MonoBehaviour
{

    Rigidbody2D rbody;
    Animator anim;
    public float speed;
    public Text test;

    // Use this for initialization
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 movement_vector_up = new Vector2(0, 1);
        Vector2 movement_vector_down = new Vector2(0, -1);
        Vector2 movement_vector_left = new Vector2(-1, 0);
        Vector2 movement_vector_right = new Vector2(1, 0);
        Vector2 movement_vector_north_east = new Vector2(1, 1);
        Vector2 movement_vector_north_west = new Vector2(-1, 1);
        Vector2 movement_vector_south_east = new Vector2(1, -1);
        Vector2 movement_vector_south_west = new Vector2(-1, -1);

        if (test.text == "up")
        {
            if (movement_vector_up != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_up.x);
                anim.SetFloat("input_y", movement_vector_up.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_up * Time.deltaTime * speed);
        }
        else if (test.text == "down")
        {
            if (movement_vector_down != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_down.x);
                anim.SetFloat("input_y", movement_vector_down.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_down * Time.deltaTime * speed);
        }
        else if (test.text == "left")
        {
            if (movement_vector_left != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_left.x);
                anim.SetFloat("input_y", movement_vector_left.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_left * Time.deltaTime * speed);
        }
        else if (test.text == "right")
        {
            if (movement_vector_right != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_right.x);
                anim.SetFloat("input_y", movement_vector_right.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_right * Time.deltaTime * speed);
        }
        else if (test.text == "north east")
        {
            if (movement_vector_north_east != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_north_east.x);
                anim.SetFloat("input_y", movement_vector_north_east.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_north_east * Time.deltaTime * speed);
        }
        else if (test.text == "north west")
        {
            if (movement_vector_north_west != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_north_west.x);
                anim.SetFloat("input_y", movement_vector_north_west.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_north_west * Time.deltaTime * speed);
        }
        else if (test.text == "south east")
        {
            if (movement_vector_south_east != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_south_east.x);
                anim.SetFloat("input_y", movement_vector_south_east.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_south_east * Time.deltaTime * speed);
        }
        else if (test.text == "south west")
        {
            if (movement_vector_south_west != Vector2.zero)
            {
                anim.SetBool("iswalking", true);
                anim.SetFloat("input_x", movement_vector_south_west.x);
                anim.SetFloat("input_y", movement_vector_south_west.y);
            }
            else
            {
                anim.SetBool("iswalking", false);
            }

            rbody.MovePosition(rbody.position + movement_vector_south_west * Time.deltaTime * speed);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }


    }
}
