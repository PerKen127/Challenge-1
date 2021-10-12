using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonMove : MonoBehaviour
{
    private Rigidbody2D leftMove;

    public bool move = false;

    private void Awake()
    {
        leftMove = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            move = true;
        }

        if (move == true)
        {
            leftMove.AddForce(new Vector2(0.0f, 200.0f) * Time.deltaTime);
        }
    }
}
