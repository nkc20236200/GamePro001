using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0_Prefab;
    float span = 0.7f;
    float delta = 0;
    void Start()
    {
        
    }


    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)  {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0_Prefab);
            int py = Random.Range(-4, 4);
            go.transform.position =new Vector3(11,py,0);
        }
    }
}
