using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPoints : MonoBehaviour
{
    public List<Vector3> waypoints; // waypoints for enemies to visit
    private Vector3 targetPoint;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        targetPoint = waypoints[index];
    }
    public bool EnemyArrived()
    {
        Debug.Log((Vector3.Distance(transform.position, targetPoint) <= 0.05f) ? true : false);
        return (Vector3.Distance(transform.position, targetPoint) <= 0.05f) ? true : false;
    }
    public void SetNextTargetPoint()
    {
        index = (index == waypoints.Count - 1) ? 0 : index + 1; // check if if u minus one from list if its 0 add one 
        targetPoint = waypoints[index]; // Update the targetPoint to the new waypoint
    }
    public Vector3 GetTargetPointDir()
    {
        return (targetPoint - transform.position).normalized;
    }
}
