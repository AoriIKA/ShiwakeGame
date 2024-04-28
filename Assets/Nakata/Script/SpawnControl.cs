using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField, Header("���X�|�[������")]
    private float SpawnTime;
    //���݂̎���
    private float time;
    //���������
    [SerializeField, Header("�������鐔")]
    private int count;
    [SerializeField, Header("��������Q�[���I�u�W�F�N�g")]
    private GameObject[] Obj;
    void Start()
    {

    }

    void Update()
    {
        //����0�ȉ��Ȃ琶����~
        if (count > 0) Spawn();
    }

    private void Spawn()
    {
        if (SpawnTime > time)
        {
            //���Ԃ����Z
            time += Time.deltaTime;
        }
        else
        {
            //�I�u�W�F�N�g����
            Instantiate(Obj[0],this.transform.position, Quaternion.identity);
            //�^�C�}�[���Z�b�g
            time = 0;
            //�c��������炷
            count--;
        }
    }
}
