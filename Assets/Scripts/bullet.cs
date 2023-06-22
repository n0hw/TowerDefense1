using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject parented;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = parented.transform.forward * 5f;

        //transform.position += transform.forward * 3f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
