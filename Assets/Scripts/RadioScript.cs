using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int progress;
    public GameController gameController;
    void Start()
    {
        gameController = FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    int GetHealth() { return health; }
    void SetHealth(int health) { if (health < 0) health = 0;  this.health = health; }
    int GetProgress() { return progress; }
    void SetProgress(int progress) { if (progress > 100) progress = 100; this.progress = progress; }
    void DecreaseHealth(int damage) { SetHealth(health - damage); }
    void IncreaseProgress(int progress) { SetProgress(this.progress + progress); }

}
