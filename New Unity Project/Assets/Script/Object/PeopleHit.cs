using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleHit : MonoBehaviour
{
    int coolTime;
    BoxCollider2D BoxCollider2D;
    Vector3 vec;
    int count;
    bool end;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        end = false;
        vec = new Vector3(0, 0, 0);
        coolTime = 0;
        BoxCollider2D = this.GetComponent<BoxCollider2D>();
    }

// Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        if(coolTime > 0 && !end)
        {
            coolTime--;

            if(coolTime == 0)
            {
                BoxCollider2D.enabled = true;
            }
        }

        if(count > 0)
        {
            if(count >30)
            {
                transform.localScale = new Vector3(1 + Mathf.Sin((50 - count) * 9 * Mathf.Deg2Rad), 1 + Mathf.Sin((50 - count) * 9 * Mathf.Deg2Rad), 1);
            }

            count--;
            if(count < 30)
            transform.position += vec;

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ARROW"))
        {
            coolTime = 120;

            BoxCollider2D.enabled = false;
        }
    }

    public void SetVec(Vector3 set)
    {
        vec = set;
        count = 50;


    }

    public void Chain()
    {
        BoxCollider2D.enabled = false;
        end = true;
    }
}
