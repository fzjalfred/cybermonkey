using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcmove1: MonoBehaviour
{
    public float runSpeed;
    private Rigidbody2D myRigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Run();
    }
    void Run()
    {
        float moveDir=Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * runSpeed, myRigidbody2D.velocity.y);
        myRigidbody2D.velocity = playerVel;
    }
}
