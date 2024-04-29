using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_Cube_cs : MonoBehaviour
{
    bool Wall_On;
    [SerializeField] Rigidbody rb;
    [SerializeField, Header("スピード,MoveSpeedは基本25")]
    private float moveSpeed;
    [SerializeField] private float fish_conbea_moveSpeed;
    bool is_hit = false;
    private bool isMoved = true;
    // Start is called before the first frame update
    void Start()
    {
        is_hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoved) return;
        if (!Wall_On)
        {
            transform.Translate(0f, 0, -fish_conbea_moveSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Test_marbas_wall")
        {
            Wall_On = true;
            if (!is_hit)
            {
                is_hit = true;
            }
        }
    }
    private void FixedUpdate()
    {
        if(is_hit) rb.AddForce(new Vector3(moveSpeed, 0f, 0f), ForceMode.Acceleration);
    }

    public void IsMoveDisableFlag()
    {
        isMoved = false;
    }

    public void InvokeDisableRigidBody()
    {
        Invoke("DisableRigidBody", 10f);
    }

   private void DisableRigidBody()
    {
        rb.isKinematic = true;
    }
}
