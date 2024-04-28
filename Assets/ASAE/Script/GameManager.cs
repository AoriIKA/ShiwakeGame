using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public enum Scene_TYPE
    {
       Title,
       Game,
       Result
    }

    [SerializeField]
    private Scene_TYPE sceneType;

    [SerializeField]
    private SpawnControl spawnScript = null;

    //魚の最大生成数
    [SerializeField]
    private int maxGenerationFishCount = 0;

    private int nowFishCount=0;

    //仕分け成功数
    [SerializeField]
    private int successCount=0;
    //仕分け失敗数
    [SerializeField]
    private int missCount = 0;

    [SerializeField]
    TMP_Text norumaCountText = null;


    /*  リザルト関係　　*/
    [SerializeField]
    GameObject resultUIObject = null;
    [SerializeField]
    TMP_Text successCountText = null;
    [SerializeField]
    TMP_Text missCountText = null;
    /*------------------------*/



    //外部から魚の最大生成数を取得用
    public int GetMaxGenerationFishCount()
    {
        return maxGenerationFishCount;
    }

    private void Awake()
    {
        //メイン生成に変更
        spawnScript.IsChengeGame();
    }


    // Start is called before the first frame update
    void Start()
    {
        sceneType = Scene_TYPE.Title;
        //現在のカウントから０になったらすべての処理が終了したとする
        nowFishCount = maxGenerationFishCount;
    }

    // Update is called once per frame
    void Update()
    {
        switch (sceneType)
        {
            case Scene_TYPE.Title:
        // 処理１

        break;
            case Scene_TYPE.Game:
        // 処理２

        break;
            case Scene_TYPE.Result:
        // 処理３
        
        break;
        }
    }

    //成功した仕分けのカウントアップ処理
    public void SetSuccessCount()
    {
        successCount++;
        norumaCountText.text = (nowFishCount-=1).ToString();//残りカウント

        //以下にnowCountが０になったらResult処理へ移行
        if (nowFishCount <= 0)
        {
            StartResultSystem();
            resultUIObject.SetActive(true);
        }
    }

    //失敗した仕分けのカウントアップ処理
    public void SetMissCount()
    {
        missCount++;
        norumaCountText.text = (nowFishCount -= 1).ToString();//残りカウント

        //以下にnowCountが０になったらResult処理へ移行
        if (nowFishCount <= 0)
        {
            StartResultSystem();
            resultUIObject.SetActive(true);
        }
    }

    void StartResultSystem()
    {
        successCountText.text = "X" + successCount.ToString();
        missCountText.text = "X" + missCount.ToString();
        //フェードアウトの処理
    }

}
