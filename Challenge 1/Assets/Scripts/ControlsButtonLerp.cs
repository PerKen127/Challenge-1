using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsButtonLerp : MonoBehaviour
{
    public float p1 = -1.0f;
    public float p2 = 1.0f;

    static float t = 0.0f;

    public bool move = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            move = true;
        }

        if (move == true)
        {
            transform.position = new Vector3(Mathf.Lerp(p1, p2, t), -4, 0);

            t += 0.5f * Time.deltaTime;
        }
    }
}
