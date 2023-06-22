using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public int health = 100;

    public Text hpText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = health.ToString();    

        if(health <= 0)
        {
            SceneManager.LoadScene("Defeat");
        }
    }





}
