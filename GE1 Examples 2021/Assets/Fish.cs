using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public Transform head;
    public Transform tail;
    [Range(0.0f, 5.0f)]
    public float frequency = 0.5f;
    public float headAmplitude = 40;
    public float tailAmplitude = 60;

    public float theta = 0;

    // Start is called before the first frame update
    void Start()
    {
        theta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float headAngle = Mathf.Sin(theta) * headAmplitude;
        float tailAngle = Mathf.Sin(theta) * tailAmplitude;

        head.localRotation = Quaternion.AngleAxis(headAngle, Vector3.forward);
        tail.localRotation = Quaternion.AngleAxis(tailAngle, Vector3.forward);

        theta += frequency * 2.0f * Mathf.PI * Time.deltaTime;

    }
}
