using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private Animator m_Animator = null;
    Animator animator;
    Rigidbody rb;
    
    void Start()
    {
        speed = 10.0f;

        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 position = new Vector3(x, y, 0);
        rb.velocity = position.normalized * speed;

        if (y > 0) { 
            //this.animator.SetTrigger
               m_Animator.SetTrigger("ue trigger");
        }
        if (y<0)  {
            // this.animator.SetTrigger
            m_Animator.SetTrigger("sita trigger");
        }




        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x , -11.0f, 11.0f),
            Mathf.Clamp(transform.position.y , -5.0f, 5.0f)
            );


    }
}
