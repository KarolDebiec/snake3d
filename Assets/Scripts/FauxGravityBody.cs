using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {

    private Rigidbody rb;
	public FauxGravityAttractor attractor;
    public PlayerController playerController;
    private Transform myTransform;
    private void OnEnable()
    {
        GameObject bigBall = GameObject.FindWithTag("BigBall");
        attractor = bigBall.GetComponent<FauxGravityAttractor>();
    }
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;
        myTransform = transform;
	}
	

	void Update () {
        playerController.MovePlayer();
        attractor.Attract(myTransform);
    }
}
