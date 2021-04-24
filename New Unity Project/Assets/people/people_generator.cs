using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people_generator : MonoBehaviour
{
    [SerializeField] List<GameObject> people;   //�l�ԃv���n�u
    [SerializeField] int maxGenerateInterval;   //�l�Ԑ����Ԋu�ő�
    [SerializeField] float maxSpeed;            //�l�ԃX�s�[�h�ő�
    [SerializeField] float minSpeed;            //�l�ԃX�s�[�h�ŏ�
    [SerializeField] float maxPosY;             //�l��Y���W�ő�
    [SerializeField] float minPosY;             //�l��Y���W�ŏ�

    int generateInterval;       //�l�Ԑ����Ԋu
    int cntInterval;            //���Ԍo�߃J�E���^�[

    // Start is called before the first frame update
    void Start()
    {
        cntInterval = 0;
        generateInterval = Random.Range(1, maxGenerateInterval);
    }

    // Update is called once per frame
    void Update()
    {
        cntInterval++;
        if(cntInterval == generateInterval)
        {
            //���Ԍo�߃J�E���^�[���Z�b�g
            cntInterval = 0;

            //�l�Ԑ����Ԋu�����_���Č���
            generateInterval = Random.Range(1, maxGenerateInterval);

            //�l�Ԑ���
            people peopleObject = Instantiate(people[Random.Range(0,people.Count)]).GetComponent<people>();

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

    }
}
