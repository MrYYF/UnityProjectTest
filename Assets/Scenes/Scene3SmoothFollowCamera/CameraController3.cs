using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3 : MonoBehaviour
{
    public GameObject player;
    public float smoothSpeed = 5f; // Æ½»¬¸úËæËÙ¶È

    void Update()
    {
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, player.transform.position, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;


    }
}
