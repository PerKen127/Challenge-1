using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButtonMove : MonoBehaviour
{
    private Rigidbody2D move;

    static float t = 0.0f;

    private void Awake()
    {
        move = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        t += 0.5f * Time.deltaTime;

        while (t < 1)
        {
            move.AddForce(new Vector2(-30.0f, 0.0f) * t);
        } 

        while (t >= 1)
        {
            move.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
