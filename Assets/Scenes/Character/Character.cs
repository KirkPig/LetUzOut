using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour, IClickable
{
    private Vector3 targetPosition;
    private bool isMoving = false;

    public int Health = 100;
    public int attack = 10;
    private float moveSpeed = 4;
    public CharacterManager characterManager;

    public int sortingOrderHigh = 30;
    public int sortingOrderLow = 0;

    private NavMeshAgent agent;



    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("DDDD");
        if (other.gameObject.tag == "Zombie")
        {
            Debug.Log("Fuck");
            Destroy(this.gameObject);
        }
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
        if (isMoving)
        {

            gameObject.GetComponent<SpriteRenderer>().sortingOrder = sortingOrderHigh;
            MoveUpdate();
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = sortingOrderLow;
        }
    }


    public void setMoveTargetPosition()
    {
        
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        

        agent.SetDestination(targetPosition);

        isMoving = true;
    }

    void MoveUpdate()
    {
        // transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        //targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //targetPosition.z = transform.position.z;

        //agent.SetDestination(targetPosition);
        if (transform.position == targetPosition)
        {
            isMoving = false;
        }
    }

    void IClickable.click()
    {
        characterManager.setSelectedCharacter(this);
    }

}
