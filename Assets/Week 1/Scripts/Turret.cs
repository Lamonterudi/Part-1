using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, speed * direction * Time.deltaTime);

       
    }
}