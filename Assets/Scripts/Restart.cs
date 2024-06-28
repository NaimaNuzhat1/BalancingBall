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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClick()
    {
        GameOverWin.gameObject.SetActive(false);
       
      
        SceneManager.LoadScene("Game");
    }
}
