using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class myinputkey : MonoBehaviour
{

    public Button[] mykeyNumberbuttons;
    public Button[] mykeyLettersbuttons;
    public Button[] mySpecialcharactersbuttons;
    public Button[] myEmailextensionbuttons;


    public InputField myNameInputField;
    public InputField myEmailInputField;
    // Start is called before the first frame update
    private string keycodeUI="";
    private bool myactionbutton;
    private string oldkeycodeUI;

    void Start()
    {
        myNameInputField = GameObject.Find("Nombre").GetComponent<InputField>();

        oldkeycodeUI = keycodeUI;
        StartCoroutine(keypresed());


        StartCoroutine(becomeinfalse());
        StartCoroutine(inputFieldsonGUI());
        for (int i = 0; i < mykeyNumberbuttons.Length; i++)
        {
           int closureIndex1 = i; // Prevents the closure problem
           mykeyNumberbuttons[closureIndex1].onClick.AddListener(() => TaskOnClick1(closureIndex1));///seagrega el listener al arrelgo de botones
        }
        for (int j = 0; j < mykeyLettersbuttons.Length; j++)
        {
            int closureIndex2 = j; // Prevents the closure problem
            mykeyLettersbuttons[closureIndex2].onClick.AddListener(() => TaskOnClick2(closureIndex2));///seagrega el listener al arrelgo de botones
        }
        //mykeyNumberbuttons.name            EventSystem.current.currentSelectedGameObject.name




    }
   

        void Update()
    {

       

        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(kcode))
            {
               // string keycode = kcode.ToString();
               // Debug.Log(kcode + "is presed");
              /* for (int i = 0; i < mykeyNumberbuttons.Length; i++)
                {
                    if (mykeyNumberbuttons[i].name == keycode)
                    {
                        Debug.Log(mykeyNumberbuttons[i].name+"is presed"); 
                    }

                }*/
            }
          
        }
    }

    IEnumerator inputFieldsonGUI()
    {

        if (EventSystem.current.currentSelectedGameObject == null)
        {
            Debug.Log("Current focus is null");
           
        }
        else if (EventSystem.current.currentSelectedGameObject != null)
        {
            string buttonName = EventSystem.current.currentSelectedGameObject.name;
            Debug.Log(buttonName + "Current focus is ");
        }
        yield return new WaitForSeconds(0.5f);   ////time to look at inputfields
    }
    IEnumerator keypresed()
    {
        while (true)
        {
            if (oldkeycodeUI != keycodeUI)
            {
                Debug.Log("You have clicked the button" + keycodeUI);
                oldkeycodeUI = keycodeUI;
            }
            else if (oldkeycodeUI == keycodeUI&& myactionbutton ==true  )
            {
                Debug.Log("You have clicked the button" + keycodeUI);
            }
            yield return new WaitForSeconds(0.05f);

        }

    }
    IEnumerator becomeinfalse()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.05f);
            myactionbutton = false;
        }
    }
            public void TaskOnClick1(int buttonIndex)
    {
        //  Debug.Log("You have clicked the button #" + buttonIndex, mykeyNumberbuttons[buttonIndex]);
        if (buttonIndex == 0)
        {
            keycodeUI = "1";
            myactionbutton= true;
        }
        else if (buttonIndex == 1)
        {
            keycodeUI = "2";
            myactionbutton = true;
        }
        else if (buttonIndex == 2)
        {
            keycodeUI = "3";
            myactionbutton = true;
        }
        else if (buttonIndex == 3)
        {
            keycodeUI = "4";
            myactionbutton = true;
        }
        else if (buttonIndex == 4)
        {
            keycodeUI = "5";
            myactionbutton = true;
        }
        else if (buttonIndex == 5)
        {
            keycodeUI = "6";
            myactionbutton = true;
        }
        else if (buttonIndex == 6)
        {
            keycodeUI = "7";
            myactionbutton = true;
        }
        else if (buttonIndex == 7)
        {
            keycodeUI = "8";
            myactionbutton = true;
        }
        else if (buttonIndex == 8)
        {
            keycodeUI = "9";
            myactionbutton = true;
        }
        else if (buttonIndex == 9)
        {
            keycodeUI = "0";
            myactionbutton = true;
        }
        

    }
    public void TaskOnClick2(int buttonIndex2)
    {
        //Debug.Log("You have clicked the button #" + buttonIndex2, mykeyLettersbuttons[buttonIndex2]);

        if (buttonIndex2 == 0)
        {
            keycodeUI = "Q";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 1)
        {
            keycodeUI = "W";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 2)
        {
            keycodeUI = "E";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 3)
        {
            keycodeUI = "R";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 4)
        {
            keycodeUI = "T";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 5)
        {
            keycodeUI = "Y";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 6)
        {
            keycodeUI = "U";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 7)
        {
            keycodeUI = "I";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 8)
        {
            keycodeUI = "O";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 9)
        {
            keycodeUI = "P";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 10)
        {
            keycodeUI = "A";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 11)
        {
            keycodeUI = "S";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 12)
        {
            keycodeUI = "D";
            myactionbutton = true;
        }
        else if (buttonIndex2 ==13)
        {
            keycodeUI = "F";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 14)
        {
            keycodeUI = "G";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 15)
        {
            keycodeUI = "H";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 16)
        {
            keycodeUI = "J";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 17)
        {
            keycodeUI = "K";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 18)
        {
            keycodeUI = "L";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 19)
        {
            keycodeUI = "Ñ";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 20)
        {
            keycodeUI = "Z";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 21)
        {
            keycodeUI = "X";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 22)
        {
            keycodeUI = "C";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 23)
        {
            keycodeUI = "V";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 24)
        {
            keycodeUI = "B";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 25)
        {
            keycodeUI = "N";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 26)
        {
            keycodeUI = "M";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 27)
        {
            keycodeUI = "-";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 28)
        {
            keycodeUI = "_";
            myactionbutton = true;
        }
        else if (buttonIndex2 == 29)
        {
            keycodeUI = "Backspace";
            myactionbutton = true;
        }
        
    }
}
