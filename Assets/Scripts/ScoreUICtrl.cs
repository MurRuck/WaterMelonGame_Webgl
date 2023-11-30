using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUICtrl : MonoBehaviour
{
    public Animation ani;
    public GameObject[] Star;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Star[0].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Star[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Star[2].SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            score.SetActive(true);
        }
    }
}
