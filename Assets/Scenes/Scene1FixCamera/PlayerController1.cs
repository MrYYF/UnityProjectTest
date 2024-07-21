using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    private float speed = 10f;
    private float jumpForce = 3f;


    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        gameObject.transform.position += Vector3.forward * vertical * Time.deltaTime * speed;
        gameObject.transform.position += Vector3.right * horizontal * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
