using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour {

    public int actualLevel;
    public int actualBody;
    public bool isLost;
    public bool addBodyPart;
    public bool respPoint;
    public float direction;
    public float speedMultiplier;

    private void Start()
    {
        Time.timeScale = 1;
    }
}
