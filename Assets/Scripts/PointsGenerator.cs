using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsGenerator : MonoBehaviour {

    private GlobalVariables globalVars;
    public GameObject pointPrefab;

    void Start () {
        GameObject globalObject = GameObject.FindWithTag("GlobalVariables");
        globalVars = globalObject.GetComponent<GlobalVariables>();
    }
	
	
	void Update () {
		if(globalVars.respPoint)
        {
            Instantiate(pointPrefab);
            globalVars.respPoint = false;
        }
	}
}
