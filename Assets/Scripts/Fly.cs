using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float jumpForse = 100;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (rb.velocity.y < 0)
            {
                rb.AddForce(Vector2.up * jumpForse, ForceMode2D.Impulse);
            }
        }
        if (rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
    }
}
