using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Transform Player;
    public Rigidbody2D rig;

    void Start()
    {
        transform.localEulerAngles = Player.transform.localEulerAngles;
        transform.position = Player.transform.position;
    }


    void Update()
    {
        transform.localPosition = transform.localPosition + Vector3.up * speed;
        
    }
}
