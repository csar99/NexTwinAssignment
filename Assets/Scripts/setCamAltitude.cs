using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class setCamAltitude : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camObject;
    public TMP_Text altitudeText;
    private float altitude;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        altitude = camObject.transform.position.y;
        altitudeText.text = (Math.Round(altitude, 2)).ToString();
    }
}
