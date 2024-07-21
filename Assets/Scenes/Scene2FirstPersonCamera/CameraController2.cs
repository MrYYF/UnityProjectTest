using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    private float mouseSensitivity = 100f;
    private float xRotation = 0;
    private float yRotation = 0;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // �����µ�X����תֵ����������-90�ȵ�90��֮��
        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Ӧ��X����ת�����
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        //transform.Rotate(Vector3.up * mouseX,xRotation);
    }
}
