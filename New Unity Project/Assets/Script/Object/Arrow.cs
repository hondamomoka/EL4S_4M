using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    float speed;
    Vector3 vec;
    int hit;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        hit = 2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position += vec * speed;

        if (transform.position.x > 15 || transform.position.x < -15)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.y > 6)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetVec(Vector3 set)
    {
        vec = set;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BOY") || other.gameObject.CompareTag("GIRL"))
        {
            hit--;

            if(hit == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
