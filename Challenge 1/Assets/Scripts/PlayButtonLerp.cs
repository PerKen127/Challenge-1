using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonLerp : MonoBehaviour
{
    public float p1 = -1.0f;
    public float p2 = 1.0f;

    static float t = 0.0f;

    public bool move = false;

    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            move = true;
        }

       if (move == true)
        {
            transform.position = new Vector3(Mathf.Lerp(p1, p2, t), 0, 0);

            t += 0.5f * Time.deltaTime;
        }
    }
}
