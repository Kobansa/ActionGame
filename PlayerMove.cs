using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public GameObject gameObject4;
    //public GameObject goal;//ゴールの変数
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 10);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 35);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -35);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-35, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(35, 0, 0);
        }
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0, 0, 2);
            //落ちたら、最初に戻るコード 0.5はエラーが出る
        }
    }

    void onCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Enermy")
        {
            //transform.position = new Vector3(0, 0, 2);
            //Enermyに当たると
        }
        if (hit.gameObject.tag == "Ground")
        {
            // transform.position = new Vector3(0, 0, 2);

        }
        if (hit.gameObject.tag == "Goal")
        {
            Destroy(this.gameObject);//意味なかったぜ！

        }

    }


}