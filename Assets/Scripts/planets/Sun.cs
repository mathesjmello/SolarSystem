using planets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sun : MonoBehaviour, IRotate {

    [SerializeField]
    private float _rotation;
    public void Rotate(float r)
    {
        transform.rotation = new Quaternion(0, _rotation, 0, 1);
    }
}
