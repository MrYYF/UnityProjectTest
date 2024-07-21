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

        // 计算新的X轴旋转值，并限制在-90度到90度之间
        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // 应用X轴旋转到相机
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        //transform.Rotate(Vector3.up * mouseX,xRotation);
    }
}
