using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNxtScene : MonoBehaviour
{
    public TMP_Dropdown dropDownMenu;
    
    
    public void loadScene()
    {

       int indexFromDropDown = dropDownMenu.value;
        
        Debug.Log(indexFromDropDown);

        switch (indexFromDropDown)
        {
            case 0:
                Debug.Log(indexFromDropDown);
                break;
            case 1:
                Debug.Log(indexFromDropDown);
                SceneManager.LoadScene("OSM3D");
                break;
            case 2:
                Debug.Log(indexFromDropDown);
                SceneManager.LoadScene("OSM3D 1");
                break;
            default:
                Debug.Log(indexFromDropDown);
                SceneManager.LoadScene("OSM3D 2");
                break;
        }

        
    }
}
