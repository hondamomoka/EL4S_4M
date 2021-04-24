using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{

    [SerializeField] ShootSE SE;         //‰¹

    public void OnClick()
    {
        SE.PlaySE();
        //SceneManager.LoadScene("GameScene");
    }
}
