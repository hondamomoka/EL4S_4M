using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupid : MonoBehaviour
{
    public GameObject arrow;
    public RotateArrow RotateArrow;
    float subx, suby;
    Arrow Arrow;
    // Start is called before the first frame update
    void Start()
    {
        subx = 0.0f;
        suby = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject cloneObject = Instantiate(arrow, transform.position, Quaternion.identity);
            Arrow = cloneObject.GetComponent<Arrow>();

            Arrow.SetVec(new Vector3(subx, suby, 0).normalized);
        }
    }

    void FixedUpdate()
    {
        Vector3 targetpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        //Debug.Log("X" + targetpos.x);
        //Debug.Log("Y" + targetpos.y);

        float angle = 1.0f;

        subx = targetpos.x - transform.position.x;
        suby = targetpos.y - transform.position.y;

        if(suby < 0.5f)
        {
            suby = 0.5f;
        }

        angle = Mathf.Atan2(suby, subx);    //Šp“xŽZo       

        float rot = angle * Mathf.Rad2Deg - 90;

        if(rot > 75)
        {
            rot = 75;
        }

        if(rot < -75)
        {
            rot = -75;
        }

        Debug.Log(rot);

        RotateArrow.SetRotate(rot);

    }
}
