using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston_cs : MonoBehaviour
{
    [SerializeField] GameObject Piston_obj;
    private float piston_Vecter_X;
    // Start is called before the first frame update
    void Start()
    {
        piston_Vecter_X = transform.position.x;
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
        transform.position = new Vector3(piston_Vecter_X, this.transform.position.y, this.transform.position.z);
    }
}
