using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;    

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Put code here to draw the gizmos
            // Use sin and cos to calculate the positions of the waypoints 
            // You can draw gizmos using
            // Gizmos.color = Color.green;
            // Gizmos.DrawWireSphere(pos, 1);
            }
        }
    }

    // Use this for initialization
    void Awake () {
        // Put code here to calculat the waypoints in a loop and 
        // Add them to the waypoints List
    }

    // Update is called once per frame
    void Update () {
        // Part 1
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one


        // Part 2
        // Put code here to check if the player is in front of or behine the tank
        // Also put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        GameManager.Log("Hello from th AI tank");
        }
    }
}
