using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ManController : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;

    private NavMeshAgent agent;

    

    public int Health { get => health; set => health = value; }

    void Awake()
    {
        Health = 20;
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
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
