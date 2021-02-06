using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    // Start is called before the first frame update

    private enum State
    {
        findTarget,
        onGoing
    }


    private int health;
    private State state;
    private GameObject target;

    public int Health { get => health; set => health = value; }

    void Awake()
    {

        state = State.findTarget;

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (state)
        {
            case State.findTarget:
                GameObject[] targetList = GameObject.FindGameObjectsWithTag("Target");
                for (int i = 0;i < targetList.Length; i++)
                {
                    GameObject targetObject = targetList[i];
                    Debug.Log(targetObject.transform.position.ToString() + " " + this.transform.position.ToString());

                }
                break;
            case State.onGoing:
                break;
        }
        
    }
}
