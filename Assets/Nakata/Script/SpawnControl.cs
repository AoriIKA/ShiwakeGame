using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField, Header("リスポーン時間")]
    private float SpawnTime;
    //現在の時間
    private float time;
    //生成する個数
    [SerializeField, Header("生成する数")]
    private int count;
    [SerializeField, Header("生成するゲームオブジェクト")]
    private GameObject[] Obj;
    void Start()
    {

    }

    void Update()
    {
        //個数が0以下なら生成停止
        if (count > 0) Spawn();
    }

    private void Spawn()
    {
        if (SpawnTime > time)
        {
            //時間を加算
            time += Time.deltaTime;
        }
        else
        {
            //オブジェクト生成
            Instantiate(Obj[0],this.transform.position, Quaternion.identity);
            //タイマーリセット
            time = 0;
            //残り個数を減らす
            count--;
        }
    }
}
