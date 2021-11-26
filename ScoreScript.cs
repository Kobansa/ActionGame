using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI機能を扱うときに追記する

public class ScoreScript : MonoBehaviour
{

    private int Score; //得点の変数
    public Text ScoreText; //得点の文字の変数
    public GameObject ScoreObject;

    void test()
    {
        Score += 2000;
    }
    
// Start is called before the first frame update
        void Start()
    {
        Score = 0; //得点を0にする
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score:" + Score.ToString(); //ScoreTextの文字をScore:Scoreの値にする

        if (Input.GetKeyDown(KeyCode.Space)) //もし、スペースキーがおされたら、
        {
            Score += 1000; //Scoreを1000ずつ変える
           
        }

    }

}
