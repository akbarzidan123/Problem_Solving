using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    public Text textTime;
    public float durtaion;
    public GameOverManager gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(durtaion <= 1)
        {
            gameOver.Show();
            Time.timeScale = 0;
        }
        textTime.text = GetRemainingTime();   
    }

    string GetRemainingTime()
    {
        int minute = Mathf.FloorToInt(durtaion / 60);
        int second = Mathf.FloorToInt(durtaion % 60);
        durtaion -= Time.deltaTime;
        return string.Format("{0} : {1}", minute.ToString(), second.ToString());
    }
}
