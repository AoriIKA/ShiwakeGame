using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image_Chenge : MonoBehaviour
{
    [Header("‹¤’Ê")]
    [SerializeField] private float span_time;
    [Header("1P")]
    [SerializeField] private Image A_Player_Image;
    [SerializeField] private Sprite[] A_Player_Sprite_Set;
    [SerializeField] private Sprite A_Player_KeyDown_Sprite;
    private bool Player_A_Keydown = false;
    private bool A_Image = false;
    [Header("2P")]
    [SerializeField] private Image B_Player_Image;
    [SerializeField] private Sprite[] B_Player_Sprite_Set;
    [SerializeField] private Sprite B_Player_KeyDown_Sprite;
    private bool Player_B_Keydown = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(A_image_roop());
        StartCoroutine(B_image_roop());
    }
    public void Player_A_KeyDown()
    {
        Player_A_Keydown = true;
        StopCoroutine(A_image_roop());
        A_Player_Image.sprite = A_Player_KeyDown_Sprite;
    }
    public void PlayerA_KeyUp()
    {
        Player_A_Keydown = false;
        StartCoroutine(A_image_roop());
    }
    IEnumerator A_image_roop()
    {
        while (!Player_A_Keydown)
        {
            yield return new WaitForSeconds(span_time);
            A_Player_Image.sprite = A_Player_Sprite_Set[1];
            yield return new WaitForSeconds(span_time);
            A_Player_Image.sprite = A_Player_Sprite_Set[0];
        }
    }
    public void Player_B_KeyDown()
    {
        Player_B_Keydown = true;
        StopCoroutine(B_image_roop());
        B_Player_Image.sprite = B_Player_KeyDown_Sprite;
    }
    public void Player_B_KeyUp()
    {
        Player_B_Keydown = false;
        StartCoroutine(B_image_roop());
    }
    IEnumerator B_image_roop()
    {
        while (!Player_B_Keydown)
        {
            yield return new WaitForSeconds(span_time);
            B_Player_Image.sprite = B_Player_Sprite_Set[1];
            yield return new WaitForSeconds(span_time);
            B_Player_Image.sprite = B_Player_Sprite_Set[0];
        }
    }
}