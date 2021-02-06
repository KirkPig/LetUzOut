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
    
    void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Zombie")
        {
            health -= collision.gameObject.GetComponent<ZombieScript>().attack;
            if (health < 0) health = 0;
        }
    }
}
