using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston_cs : MonoBehaviour
{
    [SerializeField] GameObject Piston_obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            StartCoroutine(piston_Action());
        }
    }
    IEnumerator piston_Action()
    {
        for(float i = 0; i< 10; i++)
        {
            transform.Translate(0.1f, 0, 0);
            yield return new WaitForSeconds(0.005f);
        }
        yield return new WaitForSeconds(1f);
        transform.Translate(-1.0f, 0, 0);
    }
}
