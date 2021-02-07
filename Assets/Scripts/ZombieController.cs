using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    // Start is called before the first frame update

    private enum ZombieState
    {
        findTarget,
        onGoing
    }

    public float speed = 5f;


    private int health;
    private ZombieState state;
    private GameObject target;

    private NavMeshAgent agent;

    public int Health { get => health; set => health = value; }
    public GameObject Target { get => target; set => target = value; }
    private ZombieState State { get => state; set => state = value; }

    void Awake()
    {

        State = ZombieState.findTarget;

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

        switch (State)
        {
            case ZombieState.findTarget:

                Debug.Log("Find Target");

                GameObject[] targetList = GameObject.FindGameObjectsWithTag("Target");
                if (targetList.Length > 0)
                {
                    double minDistance = Vector3.Distance(targetList[0].transform.position, transform.position);
                    Target = targetList[0];


                    for (int i = 0; i < targetList.Length; i++)
                    {
                        GameObject targetObject = targetList[i];
                        if(Vector3.Distance(targetObject.transform.position, transform.position) < minDistance)
                        {
                            minDistance = Vector3.Distance(targetObject.transform.position, transform.position);
                            Target = targetList[i];
                        }

                    }

                    State = ZombieState.onGoing;

                    

                }
                
                break;
            case ZombieState.onGoing:

                //Debug.Log("On Going " + Target.transform.position.ToString() + transform.rotation.eulerAngles.ToString());

                if(Target == null)
                {
                    State = ZombieState.findTarget;
                }
                else
                {

                    // Rotate Zombie to target
                    if (Target.transform.position.x - transform.position.y > 0)
                    {
                        if (transform.rotation.eulerAngles.z % 360 >= 270f)
                        {
                            Debug.Log("Rotate");
                            gameObject.transform.Rotate(0f, 0f, 180f);
                        }
                    }
                    else
                    {
                        if (transform.rotation.eulerAngles.z % 360 < 270f)
                        {
                            Debug.Log("Rotate");
                            gameObject.transform.Rotate(0f, 0f, 180f);
                        }
                    }

                }

                agent.SetDestination(target.transform.position);

                break;
        }
        
    }
}
