using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class console : MonoBehaviour
{

    InputField input;
    InputField.SubmitEvent se;
    public Text output;
    public Text outputMove;
    string lastMove;


    // Use this for initialization
    void Start()
    {
        input = gameObject.GetComponent<InputField>();
        se = new InputField.SubmitEvent();
        se.AddListener(SubmitInput);
        input.onEndEdit = se;

    }


    private void SubmitInput(string arg0)
    {
        DateTime data = DateTime.Now;
        string currentText = output.text;
        string time = String.Format("{0:h:mm }", data) + "root@exploit:~# ";
        string newText;

        if (arg0 == "clear")
        {
            currentText = "";
        }

        if (arg0 == "exit")
        {
            Application.LoadLevel("menu");
            print("makarena");
        }

        if (currentText != "")
            newText = currentText + "\n" + time + arg0;
        else
            newText = time + arg0;

        if (arg0 != "")
        {
            output.text = newText;
            outputMove.text = arg0;
            lastMove = arg0;
        }

        input.text = "";
        input.ActivateInputField();
    }

    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            input.text = lastMove;
        }
    }

}