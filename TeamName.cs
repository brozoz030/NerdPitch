using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeamName : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Display;
    string Nume;
    private void NameDis()
    {
        Nume = Name.theName;
        Display.GetComponent<Text>().text = Nume;
    }
}
