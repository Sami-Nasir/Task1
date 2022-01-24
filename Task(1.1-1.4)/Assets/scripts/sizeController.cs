using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeController : MonoBehaviour
{
    public GameObject gameObject;
    float x=0.10f;
    float y=0.10f;
    float z=0.10f;
    private Vector3 scale;
    private Vector3 isSet;
    private void Start()
    {
       isSet= gameObject.transform.localScale;
        scale= new Vector3(x,y,z);
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            gameObject.transform.localScale+=scale;
        }
        else if(!(Input.GetKey(KeyCode.Space))){
            gameObject.transform.localScale=isSet;
        }
    }
}
