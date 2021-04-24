//ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
//　カップルカウンター
//　制作者：なかむらの方のももか
//ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoupleCount : MonoBehaviour
{
    //インスペクタで設定できるやーつ
   [SerializeField] Text coupleText;
    //インスペクタでセット出来ないやーつ
    private int coupleCount;        //カップル数

    // Start is called before the first frame update
    void Start()
    {
        coupleCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coupleText.text= coupleCount.ToString();
    }

    //カップルを足す関数（プレイヤーが２人射貫いた時に呼び出してね！）
    public void CouplePlus()
    {
       coupleCount +=1;
	}
}
