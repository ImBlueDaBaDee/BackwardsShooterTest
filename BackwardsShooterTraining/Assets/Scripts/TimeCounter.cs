using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCounter : MonoBehaviour
{
    //countDownTime can be changed on the inspector, it is the time before the game starts (in seconds).
    //This counter stops the time until the count down is over.
    private TextMeshProUGUI counter;
    public float countDownTime;
    void Start()
    {
        counter = GetComponent<TextMeshProUGUI>();
        countDownTime += 2; 
        Time.timeScale = 0;



    }


    void Update()
    {

        CountDown();
        
    }
    void CountDown()
    {
        counter.SetText(countDownTime.ToString("0"));
        countDownTime -= +(1*Time.unscaledDeltaTime);
        if (countDownTime <= 0)
        {
            countDownTime = 0;
            Time.timeScale = 1;  
            if (counter != null)
            {
                Destroy(gameObject);
            }
        }
    }
    
}
