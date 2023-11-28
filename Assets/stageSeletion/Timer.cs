using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject TimerGame;
    public TMP_Text TimerText;

    public GameObject asdf;
    public GameObject asdf1;
    public GameObject giftbutton;

    public GameObject[] objects;


    float time = 33;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(false);
        }
        //TimerText = TimerGame.GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time > 0 && time <= 30)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(true);
            }
            TimerText.text = Math.Truncate(time).ToString();
        }


        if(time <= 0)
        {
            TimerText.text = "0";
            asdf.SetActive(true);
            asdf1.SetActive(true);
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void Setting()
    {

    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
