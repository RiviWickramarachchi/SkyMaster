using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private float gravity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    //private void FixedUpdate()
    //{
    //    movePlayer();
    //}

    private void movePlayer()
    {
        Vector2 vel = rb.velocity;
        float ang = Mathf.Atan2(vel.y, x: 10) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(x: 0, y: 0, z: ang));

        if (Input.GetMouseButton(0))
        {

            //print("hit");
            rb.AddForce(Vector2.up * gravity * Time.deltaTime * 1000f);

        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Dead");
    }
}
