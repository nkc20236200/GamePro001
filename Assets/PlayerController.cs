using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private Animator m_Animator = null;
    Rigidbody rb;
    Animator anm;
    
    void Start()
    {
        speed = 10.0f;

        rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        anm = GetComponent<Animator>();
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 position = new Vector3(x, y, 0);
        rb.velocity = position.normalized * speed;


        if (Input.GetKey(KeyCode.UpArrow)){
            anm.Play("ue trigger");
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            anm.Play("sita trigger");
        }




        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x , -11.0f, 11.0f),
            Mathf.Clamp(transform.position.y , -5.0f, 5.0f)
            );


    }
}
