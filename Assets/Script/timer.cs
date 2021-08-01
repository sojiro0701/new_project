using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float CountDownTime;
    public Text TextCountDown;
    public static bool isTimeup;
    
    // Start is called before the first frame update
    void Start()
    {
        //CountDownTime = CountDownTime;
        isTimeup = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeup == false)
        {
            TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
            CountDownTime -= Time.deltaTime;
        }
        if (CountDownTime < 0.00f)
        {
            CountDownTime = 0.00f;
            isTimeup = true;
        }
    }
}
