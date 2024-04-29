using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmAudioSource;    //���������Ă�BGM
    [SerializeField] AudioSource seAudioSource;     //���������Ă�SE

    [SerializeField] List<BGMSoundData> bgmSoundDatas;  //BGM�f�[�^�̃��X�g
    [SerializeField] List<SESoundData> seSoundDatas;    //SE�f�[�^�̃��X�g

    public float masterVolume = 1;      //�S�̂̃{�����[��
    public float bgmMasterVolume = 1;   //BGM�̃{�����[��
    public float seMasterVolume = 1;    //SE�̃{�����[��

    [SerializeField]
    private AudioClip[] SEClip;



    public static SoundManager instance;

    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�����̋Ȃ�
    public void PlayBGM(BGMSoundData.BGM bgm)
    {
        BGMSoundData data = bgmSoundDatas.Find(data => data.bgm == bgm);
        bgmAudioSource.clip = data.audioClip;
        bgmAudioSource.volume = data.volume * bgmMasterVolume * masterVolume;
        bgmAudioSource.Play();
    }


    public void PlaySE(SESoundData.SE se)
    {
        SESoundData data = seSoundDatas.Find(data => data.se == se);
        seAudioSource.volume = data.volume * seMasterVolume * masterVolume;
        seAudioSource.PlayOneShot(data.audioClip);
    }

    public void PlayoneShotSE(int index)
    {
        seAudioSource.PlayOneShot(SEClip[index]);
    }

}

[System.Serializable]
public class BGMSoundData
{
    public enum BGM
    {
        Title,
        Dungeon,
        Hoge, // ���ꂪ���x���ɂȂ�
    }

    public BGM bgm;                 //���x��         
    public AudioClip audioClip;     //���f��
    [Range(0, 1)]
    public float volume = 1;       //����
}

[System.Serializable]
public class SESoundData
{
    public enum SE
    {
        Attack,
        Damage,
        Hoge, // ���ꂪ���x���ɂȂ�
    }

    public SE se;                   //���x��
    public AudioClip audioClip;     //���f��
    [Range(0, 1)]
    public float volume = 1;        //����
}
