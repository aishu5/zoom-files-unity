using System.Collections;

using UnityEngine;

public class zoo2 : MonoBehaviour
{

    public float movespeed = 35.0f;
    public GameObject targetobject;
    private bool movingtowardstarget = false;


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
    }
}