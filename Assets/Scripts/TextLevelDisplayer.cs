using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextLevelDisplayer : MonoBehaviour {

    private GlobalVariables globalVars;
    public Text thisText;


    void Start () {
        GameObject globalObject = GameObject.FindWithTag("GlobalVariables");
        globalVars = globalObject.GetComponent<GlobalVariables>();
    }
	
	
	void Update () {
        thisText.text = globalVars.actualLevel.ToString();
	}
}
