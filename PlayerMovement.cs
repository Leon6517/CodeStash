using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 15;
    private Rigidbody2D m_body;
    private float moveX;
    private float moveY;

    // Start is called before the first frame update
    void Start()
    {
        m_body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        m_body.velocity = new Vector2(moveX*moveSpeed, moveY*moveSpeed);
    }
}
