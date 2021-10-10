using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonMove : MonoBehaviour
{
    private Rigidbody2D leftMove;

    private void Awake()
    {
        leftMove = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        leftMove.AddForce(new Vector2 (-200.0f, 0.0f) * Time.deltaTime);
    }
}
