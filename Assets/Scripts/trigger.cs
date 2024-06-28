using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Windows;
using UnityEngine.SocialPlatforms.Impl;

public class trigger : MonoBehaviour
{

    public Canvas GameOverWin;
    public TMP_Text highscore;
    public TMP_Text score;
    GameObject canvas;
    // Start is called before the first frame update

    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameOverWin.gameObject.SetActive(true);
        int result = Int32.Parse(score.text);
        int high = Int32.Parse(highscore.text);
        if (result > high)
        {
            PlayerPrefs.SetString("highScore", score.text);
        }


    }
}
