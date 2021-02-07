using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int attack;
    private Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Vertical");
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, 10 * movement);
    }
}
