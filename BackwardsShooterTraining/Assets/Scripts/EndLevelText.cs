using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndLevelText : MonoBehaviour
{
    private TextMeshProUGUI endLevelText;
    void Start()
    {
        endLevelText = GetComponent<TextMeshProUGUI>();
    }


    void Update()
    {

        if (GameManager.isLose == 1 && Time.timeScale==0)
        {
            endLevelText.SetText("You'll get it next time!");
        }
        else if (GameManager.isLose == 2 && Time.timeScale==0)
        {
            endLevelText.SetText("You Are Awesome");
        }
        else
        {
            endLevelText.SetText("");
        }
    }
}
