using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    protected bool isPinned = false;
    public float speed = 25f;
    protected Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPinned) 
            rb.MovePosition(rb.position+Vector2.up*speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Rotator"))
        {
            isPinned = true;
            transform.SetParent(collision.transform);
            Score.pinCount++;
        } else if(collision.CompareTag("Pin"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
