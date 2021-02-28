using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBobbyFly : MonoBehaviour
{
    // Start is called before the first frame update
    public float vel = 1;
    private Rigidbody2D rb;
    public Game_manager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * vel;
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        gameManager.GameOver();
    }
}