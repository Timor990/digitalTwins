using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    public Vector3 speedVector=Vector3.zero;
    private float wheelRadius = 0.3f;
    private const float PI = 3.14f;
    private List<Transform> wheelList =new List<Transform>();
    [SerializeField]
    private float wheelSpeed = 0;
    private Animator anim;
    public float speed;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update() {

    }
    private void LateUpdate()
    {
        wheelSpeed = Vector3.Magnitude(speedVector) / (2 * PI * wheelRadius) * 360;
        handleWheelRotate();
        Debug.Log(transform.forward);
        Debug.Log(transform.right);

        Debug.Log(Vector3.Angle(transform.forward, speedVector));
        Debug.Log(Mathf.Sign(Mathf.Sin(Vector3.Angle(transform.forward, speedVector))));
        anim.SetFloat("Speed", Mathf.Sign(Mathf.Sin(Vector3.Angle(transform.right, speedVector))) * Vector3.Magnitude(speedVector));
    }
    void Move() { 
    }
    void handleWheelRotate() {
        for (int i = 0; i < 4; i++) {
            
        }

    }

}
