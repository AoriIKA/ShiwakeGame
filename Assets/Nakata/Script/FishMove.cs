using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    [SerializeField, Header("�X�s�[�h")]
    private float MoveSpeed;
    private Vector3 vec = new Vector3(1, 0, 0);
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //�x�N�g�������ɉ���
        rb.AddForce(MoveSpeed * this.transform.right);
    }

    void Update()
    {
        
    }
}
