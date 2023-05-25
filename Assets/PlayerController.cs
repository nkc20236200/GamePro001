using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 0.05f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            position.x += speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            position.y += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= speed;
        }

        transform.position = position;
    }
}
