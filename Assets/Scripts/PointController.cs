using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour {

    public float sphereRadius;
    public float pointHeight;
    void Start () {
        /*float x = Random.Range(0,360);
        float y = Random.Range(0,360);
        Debug.Log(x);
        Debug.Log(y);
        Vector3 xy = new Vector3(x,y,0);

        transform.RotateAround(Vector3.zero, xy,1000000000000000);*/
        Vector3 spawnPosition = Random.onUnitSphere * (sphereRadius + pointHeight * 0.5f);
        transform.position = spawnPosition;
    }
}
