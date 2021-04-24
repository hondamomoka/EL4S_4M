using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_generator : MonoBehaviour
{
    [SerializeField] GameObject people;         //人間プレハブ
    [SerializeField] int maxGenerateInterval;   //人間生成間隔最大
    [SerializeField] float maxSpeed;            //人間スピード最大
    [SerializeField] float minSpeed;            //人間スピード最小
    [SerializeField] float maxPosY;             //人間Y座標最大
    [SerializeField] float minPosY;             //人間Y座標最小

    int generateInterval;       //人間生成間隔
    int cntInterval;            //経過時間

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
            people peopleObject = Instantiate(people).GetComponent<people>();

            if(Random.Range(0, 2) == 1)
            {
                peopleObject.SetGoRight(true);
            }
            else
            {
                peopleObject.SetGoRight(false);
            }

            peopleObject.SetSpeed(Random.Range(minSpeed, maxSpeed));
            peopleObject.SetPosY(Random.Range(minPosY, maxPosY));
        }

        cntInterval++;
    }
}
