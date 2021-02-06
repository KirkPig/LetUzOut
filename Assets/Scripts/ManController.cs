using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;

    public int Health { get => health; set => health = value; }

    void Awake()
    {
        Health = 20;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
