using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class FT : MonoBehaviour
{
    public string[] nameprogram = new string[] { "PremierePro", "VEGASPro", "Photoshop", "Illustrator", "AfterEffects" } ;
    string input;
    public Text text;


    public void Readinput(string s)
    {
        input = s;
        print(input);
    }

    public void txt()
    {
        for (int i = 0; i < nameprogram.Length; i++)
        {
            if (nameprogram[i] == input)
            {
                text.text = "[ " + "<color=green>" + nameprogram[i] + "</color>" + "] is found.";
                break;
            }
            else
            {
                text.text = "[ " + "<color=red>" + input + "</color>" + "] is not found.";
            }
        }
    }
}
