using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnermyScript : MonoBehaviour

{
    

    // Start is called before the first frame update
    //public GameObject goal;
    public Rigidbody rb;
    public GameObject gameObject2;
    private int HP;
    public Text HPText;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //HPText.text = "Score:" + HP.ToString();

    }
        void OnCollisionEnter(Collision other)//他のオブジェクトと接触している時の処理
        {
            if (other.gameObject.tag == "Player2")//もし接触しているオブジェクトのタグがplayer2なら、
            {
            //HPText.text = "Score:" + HP.ToString();
            Destroy(this.gameObject2);//このオブジェクトを消す
            // SendMessage("ApplyDamage");
            //GameObject.Find("ScoreScript.cs").SendMessage("Test");
        }

    }
  
}




