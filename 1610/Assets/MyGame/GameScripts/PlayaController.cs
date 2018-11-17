using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayaController : MonoBehaviour
{

    private Rigidbody2D rb2d;

    public float Speed;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(moveHoriz, 0);
        rb2d.AddForce(move * Speed);
    }
}
