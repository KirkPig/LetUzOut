using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour
{
    // Start is called before the first frame update
    public RadioScript radio;
    public bool isEnd;
    void Start()
    {
        isEnd = false;
        radio = FindObjectOfType<RadioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnd) return;
        if (radio.health == 0) { isEnd = true; Debug.Log("YOU LOSE"); }
        else if (radio.progress == 100) { isEnd = true; Debug.Log("YOU WIN"); }
    }
}
