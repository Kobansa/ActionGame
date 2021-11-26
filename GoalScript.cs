using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update
   //public Rigidbody rb;
   public GameObject ScoreScript;

   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)//他のオブジェクトと接触している時の処理
    {
        if (other.gameObject.tag == "Player2")//もし接触しているオブジェクトのタグがplayer2なら、
        {
            print("終わり");//このオブジェクトを消す
        }

    }
}
