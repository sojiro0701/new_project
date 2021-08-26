using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float CountDownTime;
    public Text TextCountDown;
    public static bool isTimeup;
    float steptime;
    
    // Start is called before the first frame update
    void Start()
    {
        //CountDownTime = CountDownTime;
        isTimeup = false;
        steptime = 0.00f;
    }

    // Update is called once per frame
    void Update()
    {
        steptime += Time.deltaTime;
        //残り１０秒からカウントダウンの時間を大きくする
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
        if (isTimeup == true)
        {
            SceneManager.LoadScene("end");
        }
    }
}
