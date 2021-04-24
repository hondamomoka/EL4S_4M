using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    float speed;
    Vector3 vec;
    int hit;
    Vector3 posA;
    Vector3 posB;
    PeopleHit PeopleHit_1;
    PeopleHit PeopleHit_2;

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

            if(hit == 1)
            {
                PeopleHit_1 = other.gameObject.GetComponent<PeopleHit>();
                posA = other.gameObject.transform.position;
            }

            if(hit == 0)
            {
                PeopleHit_2 = other.gameObject.GetComponent<PeopleHit>();
                posB = other.gameObject.transform.position;


                Vector3 target = (posA + posB) / 2;
                Vector3 targetA = target;
                Vector3 targetB = target;

                targetA.x += 0.5f;
                targetB.x -= 0.5f;

                Vector3 moveA = (targetA - posA) / 30;
                Vector3 moveB = (targetB - posB) / 30;

                PeopleHit_1.SetVec(moveA);
                PeopleHit_2.SetVec(moveB);
            }
 
            if (hit == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
