using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public Transform Gun;
    public float rotationX;
    public float rotationY;

    public static player controller;
    void Start()
    {
        controller = this;
        Cursor.visible = false;
    }

    
    void Update()
    {
        Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.position = transform.position + moviment * speed * Time.deltaTime;



        Vector3 mousePos = Input.mousePosition * 30;
        mousePos = Camera.main.ScreenToViewportPoint(mousePos);


       

       

       

        Vector2 direction = new Vector2(mousePos.x - transform.position.x , mousePos.y - transform.position.y );
        transform.up = direction;

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject NewBallet = Instantiate(bullet);
        }
    }
}
