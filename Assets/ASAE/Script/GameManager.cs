using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    //�O�����狛�̍ő吶�������擾�p
    public int GetMaxGenerationFishCount()
    {
        return maxGenerationFishCount;
    }

    //���������d�����̃J�E���g�A�b�v����
    public void SetSuccessCount()
    {
        successCount++;
    }

    //���s�����d�����̃J�E���g�A�b�v����
    public void SetMissCount()
    {
        missCount++;
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
}
