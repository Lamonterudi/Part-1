using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMove : MonoBehaviour
{   //declare variables to use later
    public Rigidbody2D rigidbody;
    public float force;
    Vector2 direction;
    public GameObject EggPrefab;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        //used to get rigidbody componant from game object 
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //creates egg when space bar is clicked 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(EggPrefab, spawn.position, spawn.rotation);
        }
        //creates key inputs for player 
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Speed Boost!!ed into a wall, ouch!");
    }

        private void FixedUpdate()
    {
        //creates physics for yoshi to move
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
