using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField, Header("リスポーン時間")]
    private float SpawnTime;

    //現在の時間
    private float time = 0;

    //生成を行うフラグ
    private bool Generate = true;

    [SerializeField, Header("生成する数")]
    private int count;

    [SerializeField, Header("生成するゲームオブジェクト")]
    private GameObject[] Obj;

    //生成するオブジェクトを決める数
    private int number = 0;
    
    //チュートリアルとメインを切り替えるフラグ
    private bool ChangeGame = false;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            ChangeGame = true;
            Generate = IsGenerate(Generate);
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            Generate = IsGenerate(Generate);
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
            //時間を加算
            time += Time.deltaTime;
        }
        else
        {
            //オブジェクト配列順に生成
            Instantiate(Obj[number % Obj.Length], this.transform.position, Quaternion.identity);
            //タイマーリセット
            time = 0;
            //次のオブジェクトを出す
            number++;
        }
        
    }

    private void MainSpawn()
    {
        if (!Generate) return;

        if (SpawnTime > time)
        {
            //時間を加算
            time += Time.deltaTime;
        }
        else
        {
            //オブジェクトランダムに生成
            Instantiate(Obj[Random.Range(0, Obj.Length)], this.transform.position, Quaternion.identity);
            //タイマーリセット
            time = 0;
            //残り個数を減らす
            count--;
        }
    }

    public bool IsGenerate(bool flag)
    {
        //フラグの切り替え
        flag = !flag;
        return flag;
    }
}
