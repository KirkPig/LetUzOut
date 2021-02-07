using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour
    // Start is called before the first frame update
    public RadioScript radio;
    public bool isEnd;
    public bool isWin;
    public int round;
    public const float DayTime = 10;
    public const float NightTime = 10;
    public bool isDay;
    public float timer;
    void Start()
    {
        round = 0;
        timer = 0f;
        isDay = false;
        isEnd = false;
        isWin = false;
        radio = FindObjectOfType<RadioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0f)
        {
            isDay = !isDay;
            if (isDay) round++;
            timer = isDay ? DayTime : NightTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }
        if (isEnd) return;
        if (radio.health == 0) { isEnd = true; Debug.Log("YOU LOSE"); }
        else if (radio.progress == 100) { isEnd = true; Debug.Log("YOU WIN"); }
    }

}
