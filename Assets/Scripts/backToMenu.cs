using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class backToMenu : MonoBehaviour
{
    public void loadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);

    }
}
