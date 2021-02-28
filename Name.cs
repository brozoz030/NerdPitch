using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    // Start is called before the first frame update
    static public string theName;
    public GameObject inputField;

    public GameObject textDisplay;


    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Welcome team " + theName +"!";
    }
}
