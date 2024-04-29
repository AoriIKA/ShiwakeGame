using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    [SerializeField]
    Image fadeImage = null;
    float a = 0;

    bool isOnes = false;
    public void OnButtonRetry()
    {
        a = 0;
        fadeImage.color = new Vector4(0, 0, 0, a);
        isOnes = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnes)
        {
            fadeImage.color = new Vector4(0, 0, 0, a += 0.002f);
            if (fadeImage.color.a >= 1)
            {
                SceneManager.LoadScene(1);
               
            }
        }
    }
}
