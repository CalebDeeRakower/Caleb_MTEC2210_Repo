using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    void Start()
    {
      //sr = GetComponent<SpriteRenderer>();
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
float xPos = Input.GetAxis("Horizontal");
rb.AddForce(Vector2.right *speed, ForceMode2d.Force);
      if (Input.GetKey(KeyCode.D))
      {
        transform.Translate(0, -speed * Time.deltaTime, 0);
      }
      if (Input.GetKey(KeyCode.U))
      {
        transform.Translate(0, speed * Time.deltaTime, 0);
      }
        if (Input.GetKey(KeyCode.L))

        {
          transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
          transform.Translate(speed * Time.deltaTime, 0, 0);
        }

    }
}
