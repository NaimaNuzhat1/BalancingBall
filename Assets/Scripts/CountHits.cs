using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountHits : MonoBehaviour
{
    public TMP_Text score;
    int count = 0;
    Rigidbody rb;
    public Camera myCamera;

    public Canvas GameOverWin;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = myCamera.WorldToViewportPoint(rb.position);
        if (viewPos.x > 1.0f || viewPos.x < 0f)
        {
            GameOverWin.gameObject.SetActive(true);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        count++;
        score.text = count.ToString();
    }
}
