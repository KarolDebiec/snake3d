using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc1 : MonoBehaviour {

    public Rigidbody rb;

    public Transform planet;
    public float gravityForce = 10;
    public float speed;
    //private Vector3 dir;
    private Vector3 vec1;

    void Start () {
        //Physics.gravity = Vector3.zero;
        //rb.freezeRotation = true;
        vec1 = new Vector3(-1, 0, 0);
        //dir = transform.InverseTransformDirection(transform.position);
    }

    void Update()
    {
        transform.Translate((transform.InverseTransformDirection(transform.position)+vec1) * speed * Time.deltaTime);
    }
    /*
    void FixedUpdate()
    {
        Vector3 gravityDirection = (transform.position - planet.position).normalized;
        rb.AddForce(gravityDirection * -gravityForce);
    }
    */
}
