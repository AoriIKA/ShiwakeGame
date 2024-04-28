using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFishCatcher : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager = null;
   

    private void OnCollisionEnter(Collision collision)
    {
        //GoodFishCatcher��GoodFish���ڐG����ΐ����ɃJ�E���g����ȊO��Miss�Ƃ��ăJ�E���g
        if (collision.transform.tag == "BadFish")
        {
            gameManager.SetSuccessCount();
            collision.gameObject.SetActive(false);
            Debug.Log("Good!");
        }
        else
        {
            gameManager.SetMissCount();
            collision.gameObject.SetActive(false);
            Debug.Log("Miss!!");
        }
    }
}
