using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : Singleton<WaypointManager>
{
    int waypointsIndex = 0;

    public int GetNextWaypoint()
    {
        if (waypointsIndex >= Waypoints.points.Length - 1)
        {
            waypointsIndex = 0;
        }
        else
        {
            waypointsIndex++;
        }

        return waypointsIndex;
    }
}
