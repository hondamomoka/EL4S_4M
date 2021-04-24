using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    float speed;
    Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
        vec = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position += vec * speed;
    }
}
