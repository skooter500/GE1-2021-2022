using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class Mover : MonoBehaviour
{
    private static StringBuilder message = new StringBuilder();

    public Transform target;

    public float speed = 5;

    public void OnGUI()
    {
        GUI.color = Color.white;
        GUI.Label(new Rect(0, 0, Screen.width, Screen.height), "" + message);
        if (Event.current.type == EventType.Repaint)
        {
            message.Length = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        Vector3 toTarget = target.position - transform.position;
        float distance1 = toTarget.magnitude;

        message.Append("Distance: " + distance + "\n");
        message.Append("Distance1: " + distance1);

        toTarget = Vector3.Normalize(toTarget);
        if (distance1 > 0.1f)
        {        
            transform.position = transform.position + (toTarget * speed * Time.deltaTime);
        }
        
    }
}
