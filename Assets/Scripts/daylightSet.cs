using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daylightSet : MonoBehaviour
{
    public Slider slider;
    public float variationAmount = 5f;
    public GameObject directionalLight;
    
    // Start is called before the first frame update
    void Start()
    {
       /* slider.onValueChanged.AddListener(delegate
        {
            rotateLight();
        });*/
    }

    // Update is called once per frame
    void Update()
    {
        float sliderVal = GetComponent<Slider>().value;

        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            sliderVal -= variationAmount;
        }
        else if(Input.GetKeyDown(KeyCode.PageDown)) {
            sliderVal += variationAmount;
        }

        slider.value = sliderVal;

        directionalLight.transform.rotation = Quaternion.Euler(sliderVal, -30, 0);
        //directionalLight.transform.localEulerAngles = new Vector3(sliderVal, -30, 0);
    }

   /* public void rotateLight()
    {
        float sliderVal = GetComponent<Slider>().value;

        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            sliderVal -= variationAmount;
        }
        else if (Input.GetKeyDown(KeyCode.PageUp))
        {
            sliderVal += variationAmount;
        }

        directionalLight.transform.localEulerAngles = new Vector3(sliderVal, -30, 0);
    }*/
}
