//�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[
//�@�X�R�A�J�E���^�[
//�@����ҁF�Ȃ��ނ�̕��̂�����
//�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[�[
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
     //�C���X�y�N�^�Őݒ�ł����[��
   [SerializeField] Text scoreText;
    //�C���X�y�N�^�ŃZ�b�g�o���Ȃ���[��
    private int score;        //�J�b�v����

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

    //�X�R�A�𑫂�
    public void ScorePlus(bool isNormal)
    {
      if(isNormal == true) score += 300;
      else score += 100;
	}
}
