using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_Cube_cs : MonoBehaviour
{
    bool Wall_On;
    [SerializeField] Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Wall_On)
        {
            transform.Translate(0, 0, -0.01f);
        }else
        {
            rb.AddForce(0.5f,0,0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Test_marbas_wall")
        {
            Wall_On = true;
        }
    }
}
