using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDire : MonoBehaviour
{
    private GameObject Time_Gauge;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            SceneManager.LoadScene("SampleScene");
        }
    }
}