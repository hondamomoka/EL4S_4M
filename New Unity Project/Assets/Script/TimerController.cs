//ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
//　タイマー！
//　制作者：なかむらの方のももか
//ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    //インスペクタで設定できるやーつ
   [SerializeField] Text timerText;
   [SerializeField] float totalTime;
    //ここだけで使うやーつ
	private int seconds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		timerText.text= seconds.ToString();

        //０以下になったらリザルトに飛ぶ
        if(totalTime < 0) SceneManager.LoadScene ("Result");
    }
}
