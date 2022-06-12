using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitArea : MonoBehaviour
{
    public Lifts lift;
    public MoveController moveController_;
    private Rigidbody _rigidbody;
    private void Awake()
    {
        moveController_=GameObject.FindObjectOfType<MoveController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
