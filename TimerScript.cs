﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private float Timer;
    public Text TimerText;
    private float num1;
    // Start is called before the first frame update
    void Start()
    {
        Timer = 60;
    }

    // Update is called once per frame
    void Update()
    {
        num1 = Mathf.Floor(Timer);//Timerの小数点以下を削除
        TimerText.text =  num1.ToString();
        //TimerTextの文字をTime:Timerの値にする

    if(Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
    else if(Timer <= 0)
        {
            Timer = 0;
            print("Time Up!");
        }
    }
}
