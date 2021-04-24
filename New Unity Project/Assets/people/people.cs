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
    public void SetSpeed(float s)
    {
        speed = s;
    }

    //右から左に行くならtrue
    public void SetGoRight(bool gr)
    {
        goRright = gr;
        if (goRright)
        {
            transform.Translate(-11.0f, 0.0f, 0.0f);
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 1.0f);
        }
        else
        {
            transform.Translate(11.0f, 0.0f, 0.0f);
        }
    }

    //出現y座標
    public void SetPosY(float y)
    {
        transform.Translate(0.0f, y, 0.0f);
    }
}
