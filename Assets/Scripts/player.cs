using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;
    private float rSpeed=300;


    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        transform.Rotate(Vector3.one * Time.deltaTime * rSpeed);
        
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            PlayerPrefs.SetInt("SCORE",Score.actualScore);
            Score.actualScore = 0;
        }
        if (collision.tag == "Passed")
            Score.actualScore += 20;
    }

}
