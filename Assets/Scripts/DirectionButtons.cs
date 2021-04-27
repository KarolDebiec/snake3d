using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionButtons : MonoBehaviour {

    public bool right;
    public bool left;
    
    private GlobalVariables globalVars;

    void Start()
    {
        GameObject globalObject = GameObject.FindWithTag("GlobalVariables");
        globalVars = globalObject.GetComponent<GlobalVariables>();
    }

    public void directionChange()
    {
        if(right)
        {
            globalVars.direction = 1;
            Debug.Log("prawo");
        }
        else if (left)
        {
            globalVars.direction = -1;
            Debug.Log("lewo");
        }
        Debug.Log("działa");

    }
}
