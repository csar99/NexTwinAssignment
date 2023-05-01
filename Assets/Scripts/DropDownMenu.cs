 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Esri.ArcGISMapsSDK.Components;
using Esri.GameEngine.Geometry;
using Esri.ArcGISMapsSDK.Utils.GeoCoord;

public class DropDownMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text numberText;  
    
    public void DropdownOptions(int index)
    {
        
        switch (index)
        {
            case 0:
                numberText.text = "Please select a location";
                break;
               
            case 1:
                numberText.text = "Location 1 Selected";              
                break;

            case 2:
                numberText.text = "Location 2 Selected";
                break ;

            case 3:
                numberText.text = "Location 3 Selected";
                break;

        }
    }
}
