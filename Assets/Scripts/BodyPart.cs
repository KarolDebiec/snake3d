using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour {

    public GlobalVariables globalVars;
    public int id;
	void Start () {
        GameObject globalObject = GameObject.FindWithTag("GlobalVariables");
        globalVars = globalObject.GetComponent<GlobalVariables>();
        id = globalVars.actualBody;
    }
}
