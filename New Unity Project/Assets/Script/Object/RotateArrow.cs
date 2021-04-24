using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRotate(float rot)
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, rot));
        //Debug.Log(rot);
    }
}
