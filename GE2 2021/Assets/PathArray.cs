using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathArray : MonoBehaviour
{
    public int numWaypoints = 4;
    public Vector3[] waypoints;

    void Awake() {
        
        waypoints = new Vector3[numWaypoints];
        
        for(int i = 0; i < numWaypoints; i++) {
            float x = Random.Range(-10, 10);
            float z = Random.Range(-10, 10);
            waypoints[i] = new Vector3(x, 0.5f, z);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos() {
        for(int i = 1; i < numWaypoints; i++) {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(waypoints[i], 1);
            if(i == numWaypoints - 1) {
                Gizmos.DrawLine(waypoints[i], waypoints[0]);
            } else {
                Gizmos.DrawLine(waypoints[i], waypoints[i++]);
            }
        }
    }
}
