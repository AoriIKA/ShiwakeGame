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
        for(float i = 0; i< 20; i++)
        {
            transform.Translate(0.1f, 0, 0);
            yield return new WaitForSeconds(0.005f);
        }

        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(0, 0.53f, -1.92f);
    }
}
