using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float speed = 10f;
    private float jumpForce = 5f;

    private void Start()
    {
        Cursor.visible = false; //“˛≤ÿ Û±Í÷∏’Î
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        
        transform.localPosition += transform.forward * vertical * Time.deltaTime * speed;
        transform.localPosition += transform.right * horizontal * Time.deltaTime * speed;
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
