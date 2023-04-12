using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerObjectScript : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;


    // Start is called before the first frame update
    void Start()
    {
        text.text = "00:00:00";
    }

    bool isColliding = false;

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            print("Colisionando");
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pizza") {
            isColliding = true;
            timerIsRunning = true;
            print("Entro");
        }
       

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void OnCollisionExit(Collision other)
    {
        isColliding = false;
        print("Salio");


    }
}
