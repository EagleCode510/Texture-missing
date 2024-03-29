using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class MonsterController : MonoBehaviour
{
    public GameObject liver;
    public float speed;
    public int health = 20;
    private Waypoints wpoints;
    private int waypointIndex = 0;

    void Start()
    {
        wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, wpoints.waypoints[waypointIndex].position) < 0.03f)
        {
            waypointIndex++;
            if(waypointIndex >= wpoints.waypoints.Length)
            {
                liver.GetComponent<LifeManager>().ChangeLivesNegative(1);
                Destroy(gameObject);
                
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health = health - damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            GameObject.FindWithTag("MoneyController").GetComponent<MoneyManager>().Money += 10;
            return;
        }
    }
}
