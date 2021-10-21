using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDrop : MonoBehaviour
{
    bool shooting = false;
    System.Collections.IEnumerator Drop()
    {
        int maxCount = 5;
        while(true)
        {
            
            {
                GameObject block = GameObject.CreatePrimitive(PrimitiveType.Cube);
                block.transform.position = new Vector3(0, 20, 0);
                block.AddComponent<Rigidbody>();
                block.tag = "brick";
            }
            yield return new WaitForSeconds(1);
        }
    }

    public void OnEnable()
    {
        StartCoroutine(Drop());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("brick");
        Debug.Log(bricks.Length);
        
    }
}
