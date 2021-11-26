using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnermyScript2 : MonoBehaviour

{
    // Start is called before the first frame update
    //public GameObject goal;
    public Rigidbody rb;
    public GameObject gameObject11;
    private int HP2;
    public Text HP2Text;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //HP2Text.text = "Score:" + HP2.ToString();

    }
    void OnCollisionEnter(Collision other)//他のオブジェクトと接触している時の処理
    {
        if (other.gameObject.tag == "Player2")//もし接触しているオブジェクトのタグがplayer2なら、
        {
           
            Destroy(this.gameObject11);//このオブジェクトを消す
            //SendMessage("ApplyDamage");
            //GameObject.Find("ScoreScript.cs").SendMessage("Test");
        }
       
    }


}




