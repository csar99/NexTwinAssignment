 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text numberText;

   public void DropdownOptions(int index)
    {
        switch (index)
        {
            case 0: 
                numberText.text = "No location Selected";
                break;
               
            case 1:
                numberText.text = "Location 1";
                break;

            case 2:
                numberText.text = "Location 2";
                break ;

            case 3:
                numberText.text = "Location 3";
                break;

            case 4:
                numberText.text = "Location 4";
                break;
        }
    }
}
