using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;

    private void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            int targetNum = WaypointManager.Instance.GetNextWaypoint();
            target = Waypoints.points[targetNum];
        }
    }


}
