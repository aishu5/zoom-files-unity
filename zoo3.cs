using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoo3 : MonoBehaviour {







    public int zoom = 20;
    public int normal = 60;
    public float smooth = 5;
    private bool iszoomed = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            iszoomed = !iszoomed;
        }
        if (iszoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
        }
	}
}
