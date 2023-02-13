using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject monster;

    void Start()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
        yield return new WaitForSeconds(5f);
        Instantiate(monster, new Vector3(-0.97f, 2.49f, 0f), Quaternion.identity);
        Restart();
    }

    void Restart()
    {
        StartCoroutine(spawner());
    }
}
