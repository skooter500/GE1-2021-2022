using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float fireRate = 5;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnEnable()
    {
        StartCoroutine(Shoot());
    }

    bool shooting = false;

    System.Collections.IEnumerator Shoot()
    {
        while(true)
        {
            if (Input.GetAxis("Fire1") > 0 )     
            {
                GameObject b = GameObject.Instantiate<GameObject>(bulletPrefab);
                b.transform.position = bulletSpawn.transform.position;
                b.transform.rotation = bulletSpawn.rotation;
                yield return new WaitForSeconds(1 / (float) fireRate);
            }
            else
            {
                yield return null;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
