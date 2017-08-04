using System.Collections;

using UnityEngine;

public class zoo : MonoBehaviour
{

    public float movespeed = 35.0f;
    public GameObject targetobject;
    private bool movingtowardstarget = false;
    private float lerpspeed = 0.025f;
    private Transform fromrot;
    private Transform torot;
    private bool inposition = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            if (movingtowardstarget == true)
            {
                movingtowardstarget = false;
            }
            else
            {
                fromrot = gameObject.transform;
                torot =targetobject.transform;
                movingtowardstarget = true;

            }
        }

        if (movingtowardstarget)
        {
            movetowardstarget(targetobject);
        }

    }

    public void movetowardstarget(GameObject target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movespeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target.transform.position) < 0.1)
        {
            transform.position = target.transform.position;
            inposition = true;
        }

        if (inposition)
        {
            if (Mathf.Abs(fromrot.localEulerAngles.y) < 3)
            {
                transform.rotation = target.transform.rotation;
                movingtowardstarget = false;
                inposition = false;
            }
            else
            {
                transform.rotation = Quaternion.Lerp(fromrot.rotation, torot.rotation, Time.time * lerpspeed);
            }
        }
    }
}

