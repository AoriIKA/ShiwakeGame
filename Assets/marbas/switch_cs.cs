using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_cs : MonoBehaviour
{
    bool Switch_bool=true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Switch_bool)
            {
                this.transform.rotation = Quaternion.Euler(5, -25f, -20);
                Switch_bool = false;
            }else
            {
                this.transform.rotation = Quaternion.Euler(5, 25f, -20);
                Switch_bool = true;
            }
        }
    }
}
