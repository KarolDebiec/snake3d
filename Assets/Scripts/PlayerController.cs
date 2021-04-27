using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float roationSpeed;
    private Vector3 moveDir;
    private Rigidbody rb;

    private Vector3 mousePosition;

    public Snake snakeController;
    private GlobalVariables globalVars;
    public GameObject LosePanel;

    private void Start()
    {
        GameObject globalObject = GameObject.FindWithTag("GlobalVariables");
        globalVars = globalObject.GetComponent<GlobalVariables>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        /*
        if (Input.touchCount == 0)
        {
            globalVars.direction = 0;
            globalVars.speedMultiplier = 1;
        }
        else if (Input.touchCount == 1)
        {
            mousePosition = Input.mousePosition;
            if (mousePosition.x < (Screen.width / 2))
            {
                globalVars.direction = -1;
                globalVars.speedMultiplier = 1;
            }
            else if (mousePosition.x > (Screen.width / 2))
            {
                globalVars.direction = 1;
                globalVars.speedMultiplier = 1;
            }
        }
        else if (Input.touchCount == 2)
        {
            globalVars.direction = 0;
            globalVars.speedMultiplier = 2;
        }
        */
        mousePosition = Input.mousePosition;
        if (mousePosition.y > (Screen.height / 2))
        {
            globalVars.direction = 0;
            globalVars.speedMultiplier = 2;
        }
        else if (mousePosition.x > (Screen.width / 2) && mousePosition.y < (Screen.height / 2))
        {
            globalVars.direction = 1;
            globalVars.speedMultiplier = 1;
        }
        else if (mousePosition.x < (Screen.width / 2) && mousePosition.y < (Screen.height / 2))
        {
            globalVars.direction = -1;
            globalVars.speedMultiplier = 1;
        }
        /*if (Input.GetAxis("Horizontal") != 0)
        {*/
            transform.Rotate(Vector3.up * roationSpeed * Time.deltaTime * /*Input.GetAxis("Horizontal")*/ globalVars.direction);
        //}
    }
    public void MovePlayer()
    {
        Vector3 vec1 = new Vector3(-1,0,0);
        transform.Translate((transform.InverseTransformDirection(transform.position) + vec1) * speed * globalVars.speedMultiplier * Time.deltaTime);
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("BodyPart"))
        {
            BodyPart idScript = coll.gameObject.GetComponent<BodyPart>();
            if (idScript.id > 6)
            {
                /////////////////////////Sekwencja przegrania
                OnPlayerLose();
            }
        }
        if(coll.CompareTag("Point"))
        {
            coll.gameObject.SetActive(false);
            globalVars.addBodyPart = true;
            globalVars.respPoint = true;
        }
    }

    void OnPlayerLose()
    {
        Time.timeScale = 0;
        LosePanel.SetActive(true);
    }
}

