using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_generator : MonoBehaviour
{
    [SerializeField] int maxGenerateInterval;  //êlä‘ê∂ê¨ä‘äu

    int generateInterval;
    int cntInterval;
    // Start is called before the first frame update
    void Start()
    {
        cntInterval = 0;
        generateInterval = Random.Range(0, maxGenerateInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(cntInterval == generateInterval)
        {
            cntInterval = 0;
            generateInterval = Random.Range(0, maxGenerateInterval);

        }

        cntInterval++;
    }
}
