using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    private float speed = 10f;
    private float jumpForce = 5f;


    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.localPosition += Vector3.forward * vertical * Time.deltaTime * speed;
        transform.localPosition += Vector3.right * horizontal * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
