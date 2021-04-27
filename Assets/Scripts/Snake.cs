using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour {

    /*
    public Transform ball;
    public float gravityForce = 10;

    public float speed;


    void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical") * speed;
        float x = -Input.GetAxis("Horizontal") * speed;
        Vector3 sth = new Vector3(y,x,0);
        transform.RotateAround(Vector3.zero, sth, 20 * Time.deltaTime);
    }
    */
    public List<Transform> BodyParts = new List<Transform>();

    public float mindstance;

    public int beginSize;

    public float speed;
    public float roationSpeed;

    public GameObject bodyPrefab;

    public GlobalVariables globalVars;
    private float dis;
    private Transform curBodyPart;
    private Transform PrevBodyPart;

    void Start()
    {
        GameObject globalObject = GameObject.FindWithTag("GlobalVariables");
        globalVars = globalObject.GetComponent<GlobalVariables>();
        for (int i = 0; i < beginSize-1; i++)
        {
            AddBodyPart();
        }
    }
    void Update()
    {
        Move();
        if(Input.GetKey(KeyCode.Q))
        {
            AddBodyPart();
        }
        if(globalVars.addBodyPart)
        {
            AddBodyPart();
            globalVars.addBodyPart = false;
        }
    }
    public void Move()
    {
        float curspeed = speed;
        if (Input.GetKey(KeyCode.W))
        {
            curspeed *= 2;
        }

        //BodyParts[0].Translate(BodyParts[0].forward * curspeed * Time.smoothDeltaTime, Space.World);

       /* if (Input.GetAxis("Horizontal") != 0)
        {
            BodyParts[0].Rotate(Vector3.up * roationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        }*/
        for(int i=1 ; i < BodyParts.Count ; i++)
        {
            curBodyPart = BodyParts[i];
            PrevBodyPart = BodyParts[i-1];

            dis = Vector3.Distance(PrevBodyPart.position , curBodyPart.position);

            Vector3 newPos = PrevBodyPart.position;

            newPos.y = PrevBodyPart.position.y;

            float T = Time.deltaTime * dis/mindstance * curspeed;

            if (T > 0.5f)
            {
                T = 0.5f;
            }
            curBodyPart.position = Vector3.Slerp(curBodyPart.position, newPos, T);
            curBodyPart.rotation = Quaternion.Slerp(curBodyPart.rotation, PrevBodyPart.rotation, T);
        }
    }
    public void AddBodyPart()
    {
        globalVars.actualLevel += 1;
        globalVars.actualBody += 1;
        Transform newPart = (Instantiate(bodyPrefab,BodyParts[BodyParts.Count - 1].position, BodyParts[BodyParts.Count - 1].rotation) as GameObject).transform;
        newPart.SetParent(transform);
        BodyParts.Add(newPart);
    }
}
