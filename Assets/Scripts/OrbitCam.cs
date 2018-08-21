using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCam : MonoBehaviour {

    public GameObject Target;
    Vector3 direcao;
    public float CameraVelocity = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void LateUpdate()
    {
        direcao = Target.transform.position - transform.position;
        transform.forward = direcao;
        transform.position += direcao * Time.deltaTime*CameraVelocity*TimeManager.instance.MyTimeScale;
    }
}
