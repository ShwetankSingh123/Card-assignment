using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject hand;
    public GameObject idontknow;
    public GameObject gameover;

    private void Update()
    {
        if (hand.transform.childCount<=0 && idontknow.transform.childCount<=0)
        {
            StartCoroutine(gameOver());
            
        }
    }

    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(5);
        gameover.SetActive(true);
        hand.SetActive(false);
        idontknow.SetActive(false);
    }
}
