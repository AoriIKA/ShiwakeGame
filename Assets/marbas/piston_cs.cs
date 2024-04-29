using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class piston_cs : MonoBehaviour
{
    [SerializeField] GameObject Piston_obj;
    [Space(10)]
    [Header("カメラの振動")]
    [SerializeField] private float Camera_duration;
    [SerializeField] private float Camera_strength;
    [SerializeField] Transform Camera_transform;
    private Vector3 Camera_posi;

    private float piston_Vecter_X;
    private bool piston_now;
    // Start is called before the first frame update
    void Start()
    {
        Camera_posi = Camera_transform.position;
        piston_Vecter_X = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&!piston_now)
        {
            piston_now = true;
            piston_now_Camera_Shake();
            StartCoroutine(piston_Action());
        }
    }
    IEnumerator piston_Action()
    {
        for(float i = 0; i< 20; i++)
        {
            transform.Translate(0.1f, 0, 0);
            yield return new WaitForSeconds(0.005f);
        }

        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(piston_Vecter_X, this.transform.position.y, this.transform.position.z);
        piston_now =false;
    }
    void piston_now_Camera_Shake()
    {
        Camera_transform.transform.DOShakePosition(
        duration: Camera_duration,   // 演出時間
        strength: Camera_strength  // シェイクの強さ
        ).OnComplete(() =>
        {
            Camera_transform.position = Camera_posi;
        });
    }
}
