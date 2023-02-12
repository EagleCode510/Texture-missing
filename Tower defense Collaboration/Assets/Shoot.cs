using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private int range = 10;

    void Update()
    {
        transform.Rotate(0, 0, 100 * Time.deltaTime);
    }
}
