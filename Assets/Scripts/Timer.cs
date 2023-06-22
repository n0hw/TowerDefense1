using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float min, sec;
    [SerializeField] Text timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (min <= 0 && sec <= 0)
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            if(sec <= 0)
            {
                min--;
                sec = 59;
            }
            sec -= Time.deltaTime;
            timer.text = string.Format("{0:00}", min) + ":" + string.Format("{0:00}", sec);
        }
    }
}
