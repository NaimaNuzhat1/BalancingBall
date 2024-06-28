using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    Rigidbody rb;
    public TMP_Text highscore;
    // Start is called before the first frame update

    void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
        rb.isKinematic = true;
        string score=PlayerPrefs.GetString("highScore","0");

        highscore.text = score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {

        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
