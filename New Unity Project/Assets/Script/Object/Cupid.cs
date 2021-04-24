using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupid : MonoBehaviour
{
    public RotateArrow RotateArrow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }

    void FixedUpdate()
    {
        Vector3 targetpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = 1.0f;

        float subx = targetpos.x - transform.position.x;
        float suby = targetpos.y - transform.position.y;

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
