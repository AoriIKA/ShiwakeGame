using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneMoveScript : MonoBehaviour
{
    [SerializeField]
    Material _material;

    [SerializeField]
    private float animetionSpeed = 0;

    private float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      _material.SetTextureOffset("_MainTex", new Vector2(0, speed += animetionSpeed * Time.deltaTime));
     
    }
}
