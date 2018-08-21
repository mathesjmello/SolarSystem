using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManeger : MonoBehaviour {

    public static CameraManeger instance;
    public OrbitCam Cam;
    public GameObject[] Planets;
	// Use this for initialization
	void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetValue(float procimity)
    {
        Cam.CameraVelocity = procimity;
    }
}
