using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.Windows;

public class trigger : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        GameOverWin.gameObject.SetActive(true);



    }
}
