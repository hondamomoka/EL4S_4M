using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    Renderer renderer;�@//��ʓ��ɂ��邩�̔���p

    bool goRright;      //�i�s�����@true�Ȃ�E�ɐi��
    float speed;        //�ړ����x

    bool isAppeared;   //��x��ʂɏo��������

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        isAppeared = false;
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����
        if (goRright)
        {
            transform.Translate(speed, 0.0f, 0.0f);
        }
        else
        {
            transform.Translate(-speed, 0.0f, 0.0f);
        }

        //��ʊO��������Ă���O�ɏ����Ȃ��悤�ɂ���
        if (renderer.isVisible)
        {
            isAppeared = true;
        }
        else
        {
            //��ʊO�ɏo����폜
            if (isAppeared)
            {
                Destroy(this.gameObject);
            }
        }
    }

    //�l�̕����X�s�[�h
    void SetSpeed(float s)
    {
        speed = s;
    }

    //�E���獶�ɍs���Ȃ�true
    void SetGoRight(bool gr)
    {
        goRright = gr;
    }
}