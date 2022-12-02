using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagone : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2;
    float hexagonSize = 10;

    void Start()
    {
        rb.rotation = Random.Range(0, 360);
        transform.localScale = Vector3.one * hexagonSize;

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * speed * Time.deltaTime;

        if (transform.localScale.x <= .05f)
            Destroy(gameObject);
    }
}
