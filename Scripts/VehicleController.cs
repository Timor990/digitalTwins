using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public Vector3 speedVector=Vector3.zero;
    private float wheelRadius = 0.3f;
    private const float PI = 3.14f;
    [SerializeField]
    private float wheelSpeed = 0;
    void Update() {
        wheelSpeed = Vector3.Magnitude(speedVector)/(2* PI* wheelRadius) *360;
        

    }
}
