using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform center;
    public Transform ball;
    private Transform offset;


    private void Start()
    {

    }

    void Update () {
        transform.position = 3 * ball.position;
        
        transform.LookAt(ball);
    }
}
