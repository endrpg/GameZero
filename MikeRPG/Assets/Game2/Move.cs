using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    public float speed;
    public GameObject character;

    //Rigidbody2D rb;

    // Use this for initalization
    void Start()
    {
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
      
    }

    public void moveRight()
    {

        transform.position += Vector3.right * speed * Time.deltaTime;
        //rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }

    public void moveLeft()
    {

        transform.position += Vector3.left * speed * Time.deltaTime;
        //rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }
}
