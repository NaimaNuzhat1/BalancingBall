using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalQuadWithScreen : MonoBehaviour
{
    GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        quad = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        var quadHeight = Camera.main.orthographicSize * 2;
        var quadWidth = quadHeight * Screen.width / Screen.height;
        quad.transform.localScale = new Vector3(quadWidth, quadWidth, 1f);
    }
}
