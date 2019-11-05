using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        Debug.Log("gameObject.name: " + gameObject.name);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collide");
        
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        if (transform.position.x < -17)
        {
            transform.position = transform.position + new Vector3(Mathf.Abs(horizontalInput * speed * Time.deltaTime), 0, 0);
        }
        else if (transform.position.x > 17)
        {
            //transform.position = transform.position + new Vector3(((horizontalInput * speed * Time.deltaTime) - (horizontalInput * speed * Time.deltaTime)), 0, 0);
            //transform.position = transform.position - new Vector3((horizontalInput * speed * Time.deltaTime), 0, 0);
            transform.position = transform.position - new Vector3(Mathf.Abs(horizontalInput * speed * Time.deltaTime), 0, 0);
        }
        else
        {
            transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
        }

        //if (transform.position.x > 17)
        //{
        //    transform.position = transform.position + new Vector3(((horizontalInput * movementSpeed * Time.deltaTime) - (horizontalInput * movementSpeed * Time.deltaTime)), 0, 0);
        //}
        //if (transform.position.x > -17)
        //{
        //    transform.position = transform.position + new Vector3((Math.Abs(horizontalInput * movementSpeed * Time.deltaTime), 0, 0));
        //}
        //else
        //{
        //    horizontalInput* speed * Time.deltaTime;
        //}

        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * speed);*/
    }
}
