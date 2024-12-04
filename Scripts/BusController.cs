using System;
using UnityEngine;

public class BusController : MonoBehaviour
{
    public float speed = 5f; // 移动速度
    public Vector3 targetPosition; // 目标位置
    //public Transform rearLeftWheel,rearRightWheel;
    private Vector3 rotationCenter;
    private Vector3 velocity = Vector3.zero;
    private float rotationAngle;
    void Start() {
        //rotationCenter = (rearLeftWheel.position + rearRightWheel.position) / 2;
        rotationAngle = Vector3.Angle(transform.forward,targetPosition-transform.position);
        UnityEngine.Debug.Log(rotationAngle);
    }
    void Update()
    {
        // 根据输入更新目标位置
        //UpdateTargetPosition();

        // 移动车辆到目标位置
        MoveVehicle();
    }
    void MoveVehicle(){
        // 平滑移动车辆到目标位置
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 10*Time.deltaTime * speed);
        if (rotationAngle != 180)
        {
            Quaternion targetQuaternion = Quaternion.Euler(new Vector3(0, 0.1f * rotationAngle, 0));

            // 平滑旋转到目标角度
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQuaternion, 50 * Time.deltaTime);

        }
        // 计算目标的四元数
    }
}