using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_generator : MonoBehaviour
{
    [SerializeField] GameObject people;         //�l�ԃv���n�u
    [SerializeField] int maxGenerateInterval;   //�l�Ԑ����Ԋu�ő�
    [SerializeField] float maxSpeed;            //�l�ԃX�s�[�h�ő�
    [SerializeField] float minSpeed;            //�l�ԃX�s�[�h�ŏ�
    [SerializeField] float maxPosY;             //�l��Y���W�ő�
    [SerializeField] float minPosY;             //�l��Y���W�ŏ�

    int generateInterval;       //�l�Ԑ����Ԋu
    int cntInterval;            //�o�ߎ���

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
