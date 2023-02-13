using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform target;
    public float range;


    void UpdateTarget()
    {

    }
    void Update()
    {
        
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
