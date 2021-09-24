using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int width = 10;
    public int height = 10;

    // Start is called before the first frame update
    void Start()
    {
        int half = width / 2;
        for(int row = 0 ; row < height ; row ++)
        {
            for (int col = 0 ; col < width ; col ++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = transform.TransformPoint(new Vector3(-half + col, 0.5f + row, 0));
                cube.transform.rotation = transform.rotation;
                cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
                cube.AddComponent<Rigidbody>();
                cube.transform.parent = this.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
