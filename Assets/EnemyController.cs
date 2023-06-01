using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("MyChar_1");
    }

    void Update()
    {
        transform.Translate(-0.3f, 0, 0);

        if (transform.position.x < -11.0f)  {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 1.0f;
        float r2 = 0.7f;

        if (d < r1 + r2)  {
            Destroy(gameObject);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseTime();
        }
    }
}
