using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    [SerializeField, Header("スピード")]
    private float MoveSpeed;
    private Vector3 vec = new Vector3(1, 0, 0);
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //ベクトル方向に押す
        rb.AddForce(MoveSpeed * this.transform.right);
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Pistonに触れたら
        if(collision.gameObject.name == "Piston")
        {
            //力をリセット
            rb.AddForce(MoveSpeed * new Vector3(0, 0, 0));

            rb.AddForce(MoveSpeed * -this.transform.forward);
        }
    }
}
