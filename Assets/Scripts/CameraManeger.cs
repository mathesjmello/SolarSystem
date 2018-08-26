using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManeger : MonoBehaviour {

    public static CameraManeger Instance;
    public OrbitCam Cam;
    public GameObject[] Planets;
	// Use this for initialization
	void Start () {
        Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetValue(float procimity)
    {
        Cam.CameraVelocity = procimity;
    }

	public void GoTo(int i)
	{
		Cam.Target = Planets[i];
	}
}
