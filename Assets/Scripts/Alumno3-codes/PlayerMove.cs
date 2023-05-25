using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    float alfa;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 move;
    Vector2 mousePos;


    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        alfa = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; // Mathf.Rad2Deg es para que los radianes que da el arcotangente te lo devuelva en angulo decimal
        rb.rotation = alfa;
    }
}
