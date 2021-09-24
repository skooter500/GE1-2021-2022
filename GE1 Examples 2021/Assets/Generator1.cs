using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float radius = 20;
    public int points = 10;

    // Start is called before the first frame update
    void Start()
    {
        float theta  = (Mathf.PI * 2.0f) / (float) points;
        for (int i = 0 ; i < points ; i ++)
        {
            float angle = theta * i;
            Vector3 position = new Vector3(
                Mathf.Sin(angle) * radius,
                Mathf.Cos(angle) * radius,
                0
            );
            Debug.Log(angle);
            Debug.Log(position);
            GameObject obj = GameObject.Instantiate(prefab, position, Quaternion.identity);
            obj.transform.parent = transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
