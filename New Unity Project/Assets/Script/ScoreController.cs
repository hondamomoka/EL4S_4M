//ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
//　スコアカウンター
//　制作者：なかむらの方のももか
//ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
     //インスペクタで設定できるやーつ
   [SerializeField] Text scoreText;
    //インスペクタでセット出来ないやーつ
    private int score;        //カップル数

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text= score.ToString();
    }

    //スコアを足す
    public void ScorePlus(bool isNormal)
    {
      if(isNormal == true) score += 300;
      else score += 100;
	}
}
