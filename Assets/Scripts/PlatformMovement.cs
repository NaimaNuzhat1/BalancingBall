using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlatformMovement : MonoBehaviour
{
    float speed = 10.0f;
    Rigidbody rb;
    Vector3 movement;
    public Camera myCamera;
    public Canvas GameOverWin;
   float collisionSpeed = -200f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = 0f;
        if (this.gameObject.name == "Platform")
        {
            

            if (Input.GetKey(KeyCode.RightArrow))
            {
                moveHorizontal = 1.0f;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveHorizontal = -1.0f;
            }
            movement = new Vector3(moveHorizontal, 0f, 0f);
        }

        if (this.gameObject.name == "Platform WASD")
        {
            

            if (Input.GetKey(KeyCode.D))
            {
                moveHorizontal = 1.0f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveHorizontal = -1.0f;
            }
            movement = new Vector3(moveHorizontal, 0f, 0f);
        }
    }
    private void FixedUpdate()
    {
        moveCharecter(movement);
    }
    void moveCharecter(Vector3 direction)
    {
        Vector3 viewPos = myCamera.WorldToViewportPoint(rb.position);
        if (viewPos.x <= 0.9f && viewPos.x >= 0.1f &&
            ((this.gameObject.name == "Platform" && viewPos.x >= 0.6f) || 
            (this.gameObject.name == "Platform WASD" && viewPos.x <= 0.4f)))
        {
            rb.isKinematic = true;
            rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));

        }
        else
        {
            rb.isKinematic = false;
            rb.AddForce(direction * speed *collisionSpeed);
           
        }

    }
}
