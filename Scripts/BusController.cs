using System;
using UnityEngine;

public class BusController : MonoBehaviour
{
    public float speed = 5f; // �ƶ��ٶ�
    public Vector3 targetPosition; // Ŀ��λ��
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
        // �����������Ŀ��λ��
        //UpdateTargetPosition();

        // �ƶ�������Ŀ��λ��
        MoveVehicle();
    }
    void MoveVehicle(){
        // ƽ���ƶ�������Ŀ��λ��
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 10*Time.deltaTime * speed);
        if (rotationAngle != 180)
        {
            Quaternion targetQuaternion = Quaternion.Euler(new Vector3(0, 0.1f * rotationAngle, 0));

            // ƽ����ת��Ŀ��Ƕ�
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQuaternion, 50 * Time.deltaTime);

        }
        // ����Ŀ�����Ԫ��
    }
}