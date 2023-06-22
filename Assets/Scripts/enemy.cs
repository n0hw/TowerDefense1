using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{

    private Transform BasePos;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        BasePos = GameObject.FindGameObjectWithTag("BasePos").transform;

        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(BasePos.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Base")
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Base>().health -= 5;
        }
    }
}
