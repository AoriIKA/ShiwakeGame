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
        //GoodFishCatcherにGoodFishが接触すれば成功にカウントそれ以外はMissとしてカウント
        if (other.transform.tag == "BadFish")
        {
            gameManager.SetSuccessCount();
            SoundManager.instance.PlayoneShotSE(SESoundData.SE.SE_GoodCarry);
            //other.transform.parent = parentObject;//魚オブジェクトを籠の子にする
            other.transform.tag = "InspectedFish";
            other.GetComponent<Debug_Cube_cs>().IsMoveDisableFlag();
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.GetComponent<Debug_Cube_cs>().InvokeDisableRigidBody();
            Debug.Log("Good!");
        }
        else if (other.transform.tag == "GoodFish" || other.transform.tag == "DontFish")
        {
            gameManager.SetMissCount();
            SoundManager.instance.PlayoneShotSE(SESoundData.SE.SE_BadCarry);
          //  other.transform.parent = parentObject;//魚オブジェクトを籠の子にする
            other.transform.tag = "InspectedFish";
            other.GetComponent<Debug_Cube_cs>().IsMoveDisableFlag();
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.GetComponent<Debug_Cube_cs>().InvokeDisableRigidBody();
            Debug.Log("Miss!!");
        }
    }
}
