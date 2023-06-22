using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{

    private GameObject[] enemyes;
    public GameObject bulletPrefab;
    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("shoot", 1);
    }

    // Update is called once per frame
    void Update()
    {
        enemyes = GameObject.FindGameObjectsWithTag("enemy");

        if(enemyes.Length > 0)
        {
            Transform closest = GetClosestEnemy(enemyes);

            transform.LookAt(closest);
        }
    }

    Transform GetClosestEnemy(GameObject[] enemies)
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (GameObject t in enemies)
        {
            float dist = Vector3.Distance(t.transform.position, currentPos);
            if (dist < minDist)
            {
                tMin = t.transform;
                minDist = dist;
            }
        }
        return tMin;
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPos.position, Quaternion.identity);
        bullet.GetComponent<bullet>().parented = gameObject;


        Invoke("shoot", 2);
    }
}
