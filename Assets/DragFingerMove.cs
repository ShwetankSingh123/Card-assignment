using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerMove : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;   //for moving the card
    private Vector3 direction;  //from card position to touch position
    private float moveSpeed = 10f;  //speed in which the card will move


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //rigidbody component is assigned to the rb
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;  //to ristrict the card from moving in 3D
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;  //rigidbody gets the direction and multiplied by speed

            if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;  //if the finger is released the set the velocity to zero
            }
        }
    }
}
