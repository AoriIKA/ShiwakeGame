using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFishCatcher : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager = null;

    [SerializeField]
    private Transform parentObject = null;

    private void OnTriggerEnter(Collider other)
    {
        //GoodFishCatcher��GoodFish���ڐG����ΐ����ɃJ�E���g����ȊO��Miss�Ƃ��ăJ�E���g
        if (other.transform.tag == "BadFish")
        {
            gameManager.SetSuccessCount();
            other.transform.parent = parentObject;//���I�u�W�F�N�g���Ă̎q�ɂ���
            other.transform.tag = "InspectedFish";
            other.GetComponent<Debug_Cube_cs>().IsMoveDisableFlag();
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.GetComponent<Debug_Cube_cs>().InvokeDisableRigidBody();
            Debug.Log("Good!");
        }
        else if (other.transform.tag == "GoodFish" || other.transform.tag == "DontFish")
        {
            gameManager.SetMissCount();
            other.transform.parent = parentObject;//���I�u�W�F�N�g���Ă̎q�ɂ���
            other.transform.tag = "InspectedFish";
            other.GetComponent<Debug_Cube_cs>().IsMoveDisableFlag();
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.GetComponent<Debug_Cube_cs>().InvokeDisableRigidBody();
            Debug.Log("Miss!!");
        }
    }
}
