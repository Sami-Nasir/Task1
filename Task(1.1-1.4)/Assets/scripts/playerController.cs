using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gObject;
    public float horizontal;
    public float Speed=2.0f;
    private Rigidbody rb;
    
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=(Input.GetAxis("Horizontal"))*Speed*Time.deltaTime;
        transform.Translate(Vector3.left*horizontal);
        horizontal=(Input.GetAxis("Vertical"))*Speed*Time.deltaTime;
        transform.Translate(Vector3.forward*horizontal);
    }
}
