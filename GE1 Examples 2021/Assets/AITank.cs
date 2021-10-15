using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    public List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;    

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            float theta = (Mathf.PI * 2.0f) / numWaypoints;
            for(int i = 0 ; i < numWaypoints ; i ++)
            {
                float angle = theta * i;
                Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
                pos = transform.TransformPoint(pos);
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(pos, 1); 
            }

        }
    }

    // Use this for initialization
    void Awake () {
        float theta = (Mathf.PI * 2.0f) / numWaypoints;
        for(int i = 0 ; i < numWaypoints ; i ++)
        {
            float angle = theta * i;
            Vector3 pos = new Vector3(Mathf.Sin(angle) * radius, 0, Mathf.Cos(angle) * radius);
            pos = transform.TransformPoint(pos);
            waypoints.Add(pos); 
        }
    }

    // Update is called once per frame
    void Update () {
        Vector3 pos = transform.position;
        Vector3 toNext = waypoints[current] - pos;
        float dist = toNext.magnitude;
        if (dist < 1)
        {
            current = (current + 1) % waypoints.Count;
        }
        Vector3 direction = toNext / dist;
        pos += direction * speed * Time.deltaTime;
        transform.position = pos;
        transform.forward = toNext;

    }
}
