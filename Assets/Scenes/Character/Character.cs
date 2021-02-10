using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IClickable
{
    private Vector3 targetPosition;
    private bool isMoving = false;

    public int Health = 100;
    public int attack = 10;
    private float moveSpeed = 4;
    public CharacterManager characterManager;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if (isMoving)
        {
            MoveUpdate();
        }
    }


    public void setMoveTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        isMoving = true;
    }

    void MoveUpdate()
    {
        // transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
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
