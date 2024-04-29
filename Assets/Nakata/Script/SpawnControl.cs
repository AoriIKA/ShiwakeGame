using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField, Header("���X�|�[������")]
    private float SpawnTime;

    //���݂̎���
    private float time = 0;

    //�������s���t���O
    private bool Generate = true;

    [SerializeField, Header("�������鐔")]
    private int count;

    [SerializeField, Header("��������Q�[���I�u�W�F�N�g")]
    private GameObject[] Obj;

    //��������I�u�W�F�N�g�����߂鐔
    private int number = 0;
    
    //�`���[�g���A���ƃ��C����؂�ւ���t���O
    private bool ChangeGame = false;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            IsGenerate();
            IsChengeGame();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            IsGenerate();
            //SoundManager.instance.PlayoneShotSE(0);
        }

        if(!ChangeGame)
        {
            TutorialSpawn();
        }
        else
        {
            if (count > 0) MainSpawn();
        }

    }

    private void TutorialSpawn()
    {
        if (!Generate) return;

        if (SpawnTime > time)
        {
            //���Ԃ����Z
            time += Time.deltaTime;
        }
        else
        {
            //�I�u�W�F�N�g�z�񏇂ɐ���
            Instantiate(Obj[number % Obj.Length], this.transform.position, Quaternion.identity);
            //�^�C�}�[���Z�b�g
            time = 0;
            //���̃I�u�W�F�N�g���o��
            number++;
        }
        
    }

    private void MainSpawn()
    {
        if (!Generate) return;

        if (SpawnTime > time)
        {
            //���Ԃ����Z
            time += Time.deltaTime;
        }
        else
        {
            //�I�u�W�F�N�g�����_���ɐ���
            Instantiate(Obj[Random.Range(0, Obj.Length)], this.transform.position, Quaternion.identity);
            //�^�C�}�[���Z�b�g
            time = 0;
            //�c��������炷
            count--;
        }
    }

    //�������~����֐�
    public void IsGenerate()
    {
        Generate = !Generate;
    }

    //�z�񏇂ƃ����_��������؂�ւ���֐�
    public void IsChengeGame()
    {
        ChangeGame = !ChangeGame;
    }

}
