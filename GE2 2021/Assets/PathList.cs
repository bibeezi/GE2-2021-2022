using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathList : MonoBehaviour
{
    public int numWaypoints = 4;
    public List<Vector3> waypoints = new List<Vector3>();
    public GameObject boid;

    void Awake() {
        for(int i = 0; i < numWaypoints; i++) {
            float x = Random.Range(-10, 10);
            float z = Random.Range(-10, 10);
            waypoints.Add(new Vector3(x, 0.5f, z));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos() {
        for(int i = 0; i < numWaypoints; i++) {
            
            Gizmos.color = Color.red;
            
            Gizmos.DrawWireSphere(waypoints[i], 1);

            if(i == numWaypoints - 1) {
                Gizmos.DrawLine(waypoints[i], waypoints[0]);
            } else {
                Gizmos.DrawLine(waypoints[i], waypoints[i + 1]);
            }
        }
    }
}
