using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSE : MonoBehaviour
{
    [SerializeField] AudioClip SE;

    public void PlaySE()
    {
        this.GetComponent<AudioSource>().PlayOneShot(SE);
    }
}
