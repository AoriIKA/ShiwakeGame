using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Drawing;

public class TitleScript : MonoBehaviour
{
    bool isPushSpace = false;
    bool isPushEnter = false;

    [SerializeField]
    Image fadeImage = null;

    float a = 0;

    bool isOnes = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) isPushSpace = true;
        if (Input.GetKeyDown(KeyCode.Return)) isPushEnter = true;

        if(isPushSpace && isPushEnter && !isOnes)
        {
            fadeImage.color = new Vector4(0,0,0,a+=0.002f);
            if(fadeImage.color.a >=1)
            {
                SceneManager.LoadScene(1);
                isOnes = true;
            }
        }
    }


}
