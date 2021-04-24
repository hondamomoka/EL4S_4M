using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class people : MonoBehaviour
{
    Renderer renderer;　//画面内にいるかの判定用

    bool goRright;      //進行方向　trueなら右に進む
    float speed;        //移動速度

    bool isAppeared;   //一度画面に出現したか

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        isAppeared = false;
    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        if (goRright)
        {
            transform.Translate(speed, 0.0f, 0.0f);
        }
        else
        {
            transform.Translate(-speed, 0.0f, 0.0f);
        }

        //画面外から入ってくる前に消えないようにする
        if (renderer.isVisible)
        {
            isAppeared = true;
        }
        else
        {
            //画面外に出たら削除
            if (isAppeared)
            {
                Destroy(this.gameObject);
            }
        }
    }

    //人の歩くスピード
    void SetSpeed(float s)
    {
        speed = s;
    }

    //右から左に行くならtrue
    void SetGoRight(bool gr)
    {
        goRright = gr;
    }
}
