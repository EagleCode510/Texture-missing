using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform target;
    public float range;
    public float rotationSpeed = 10f;
    public string enemyTag = "Enemy";

    public Transform partToRotate;

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if  (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    void Update()
    {

        if (target == null)
            return;

        Vector3 targ = target.transform.position;
        targ.z = 0f;

        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float curRotation = Mathf.Atan2(objectPos.y, objectPos.x);
        float lookRotation = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;

        partToRotate.rotation = Quaternion.Euler(new Vector3(0, 0, lookRotation));
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
