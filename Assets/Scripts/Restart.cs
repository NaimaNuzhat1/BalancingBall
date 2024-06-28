using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Restart : MonoBehaviour
{

    public Canvas GameOverWin;
    public GameObject ball;
    public TMP_Text highscore;
    public TMP_Text score;
    public GameObject platform;
    Rigidbody p;
    // Start is called before the first frame update
    void Start()
    {
        p = platform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClick()
    {
        GameOverWin.gameObject.SetActive(false);
       
        int result = Int32.Parse(score.text);
        int high = Int32.Parse(highscore.text);
        if (result > high)
        {
            PlayerPrefs.SetString("highScore", score.text);
        }
        SceneManager.LoadScene("Game");
    }
}
