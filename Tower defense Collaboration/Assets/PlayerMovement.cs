using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;


    void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal")* moveSpeed;
        float movementY = Input.GetAxisRaw("Vertical") * moveSpeed;

        transform.Translate(Vector3.right * movementX * Time.deltaTime);
        transform.Translate(Vector3.up * movementY * Time.deltaTime);
    }
}
