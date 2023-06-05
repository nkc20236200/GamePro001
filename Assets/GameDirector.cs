using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameDirector : MonoBehaviour
{
    GameObject Time_Gauge;
    private float time;
        void Start()
    {
        
        Application.targetFrameRate = 60;
        time = 0;
        this.Time_Gauge = GameObject.Find("Time_Gauge");
        
    }

    public void DecreaseTime()  {
        this.Time_Gauge.GetComponent<Image>().fillAmount -= 0.1f;

    }

    void Update()
    {

        time += Time.deltaTime;
        if (time > 0)  {
            this.Time_Gauge.GetComponent<Image>().fillAmount -= 0.01f/60;
        }
        if (this.Time_Gauge.GetComponent<Image>().fillAmount == 0.0f){
            SceneManager.LoadScene("titlescene");
        }

        

        
    }

    int score(int a)  {
        return a * 60;
    }
}
