using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmAudioSource;    //今かかってるBGM
    [SerializeField] AudioSource seAudioSource;     //今かかってるSE

    [SerializeField] List<BGMSoundData> bgmSoundDatas;  //BGMデータのリスト
    [SerializeField] List<SESoundData> seSoundDatas;    //SEデータのリスト

    public float masterVolume = 1;      //全体のボリューム
    public float bgmMasterVolume = 1;   //BGMのボリューム
    public float seMasterVolume = 1;    //SEのボリューム

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

    //引数の曲を
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
        Hoge, // これがラベルになる
    }

    public BGM bgm;                 //ラベル         
    public AudioClip audioClip;     //音素材
    [Range(0, 1)]
    public float volume = 1;       //音量
}

[System.Serializable]
public class SESoundData
{
    public enum SE
    {
        Attack,
        Damage,
        Hoge, // これがラベルになる
    }

    public SE se;                   //ラベル
    public AudioClip audioClip;     //音素材
    [Range(0, 1)]
    public float volume = 1;        //音量
}
