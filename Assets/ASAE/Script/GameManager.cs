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

    //���̍ő吶����
    [SerializeField]
    private int maxGenerationFishCount = 0;

    private int nowFishCount=0;

    //�d����������
    [SerializeField]
    private int successCount=0;
    //�d�������s��
    [SerializeField]
    private int missCount = 0;

    [SerializeField]
    TMP_Text norumaCountText = null;


    /*  ���U���g�֌W�@�@*/
    [SerializeField]
    GameObject resultUIObject = null;
    [SerializeField]
    TMP_Text successCountText = null;
    [SerializeField]
    TMP_Text missCountText = null;
    /*------------------------*/



    //�O�����狛�̍ő吶�������擾�p
    public int GetMaxGenerationFishCount()
    {
        return maxGenerationFishCount;
    }

    private void Awake()
    {
        //���C�������ɕύX
        spawnScript.IsChengeGame();
    }


    // Start is called before the first frame update
    void Start()
    {
        sceneType = Scene_TYPE.Title;
        //���݂̃J�E���g����O�ɂȂ����炷�ׂĂ̏������I�������Ƃ���
        nowFishCount = maxGenerationFishCount;
    }

    // Update is called once per frame
    void Update()
    {
        switch (sceneType)
        {
            case Scene_TYPE.Title:
        // �����P

        break;
            case Scene_TYPE.Game:
        // �����Q

        break;
            case Scene_TYPE.Result:
        // �����R
        
        break;
        }
    }

    //���������d�����̃J�E���g�A�b�v����
    public void SetSuccessCount()
    {
        successCount++;
        norumaCountText.text = (nowFishCount-=1).ToString();//�c��J�E���g

        //�ȉ���nowCount���O�ɂȂ�����Result�����ֈڍs
        if (nowFishCount <= 0)
        {
            StartResultSystem();
            resultUIObject.SetActive(true);
        }
    }

    //���s�����d�����̃J�E���g�A�b�v����
    public void SetMissCount()
    {
        missCount++;
        norumaCountText.text = (nowFishCount -= 1).ToString();//�c��J�E���g

        //�ȉ���nowCount���O�ɂȂ�����Result�����ֈڍs
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
        //�t�F�[�h�A�E�g�̏���
    }

}
