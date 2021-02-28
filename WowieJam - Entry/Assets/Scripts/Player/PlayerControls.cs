using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    
    enum Actions
    {
        dialogue,
        action
    }

    public GameObject body, target;

    Playercontrols controls;
    bool canMove, dialogue, action;
    int direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        controls = new Playercontrols();

        controls.Playeractions.Movement.performed += ctx => direction = ctx.ReadValue<int>();
        controls.Playeractions.Movement.canceled += ctx => direction = 0;

        controls.Playeractions.Interact.performed += ctx => PerformAction();
    }

    private void PerformAction()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchBodies()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Entry"))
        {
            
        }
        if (other.CompareTag("Dialogue"))
        {

        }
    }

    private void OnEnable()
    {
        controls.Playeractions.Enable();
    }

    private void OnDisable()
    {
        controls.Playeractions.Disable();
    }

}
