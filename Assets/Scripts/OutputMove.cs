using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OutputMove : MonoBehaviour {

    Text score;
    float myTimer = 0.2f;

    // Use this for initialization
    void Start ()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GetComponent<Text>();

        if (score.text == "up" || score.text == "down" || score.text == "right" || score.text == "left" || score.text == "north east" || score.text == "south east" || score.text == "south west" || score.text == "north west")
        {
            if (myTimer > 0)
                myTimer -= Time.deltaTime;

            if (myTimer <= 0)
            {
                score.text = "";
                myTimer = 0.2f;
            }
        }


    }
}
