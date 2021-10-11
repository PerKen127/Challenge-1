using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonFunction : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
