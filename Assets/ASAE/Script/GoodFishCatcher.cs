using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFishCatcher : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager = null;
  

    private void OnTriggerEnter(Collider other)
    {
        //GoodFishCatcherにGoodFishが接触すれば成功にカウントそれ以外はMissとしてカウント
        if (other.transform.tag == "GoodFish")
        {
            gameManager.SetSuccessCount();
            other.transform.tag = "InspectedFish";
            other.GetComponent<Debug_Cube_cs>().enabled = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Debug.Log("Good!");
        }
        else if (other.transform.tag == "BadFish" || other.transform.tag == "DontFish")
        {
            gameManager.SetMissCount();
            other.transform.tag = "InspectedFish";
            other.GetComponent<Debug_Cube_cs>().enabled = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Debug.Log("Miss!!");
        }
    }
}
