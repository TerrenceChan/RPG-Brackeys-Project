﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof( PlayerMotor ) )]
public class PlayerController : MonoBehaviour
{
    public LayerMask moveMask;

    Camera cam;
    PlayerMotor motor;
    
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }
    
    void Update()
    {
        if ( Input.GetMouseButton( 0 ) )
        {
            Ray ray = cam.ScreenPointToRay( Input.mousePosition );
            RaycastHit hit;

            if ( Physics.Raycast( ray, out hit, 100, moveMask ) )
            {
                // Move player towards hit.
                motor.MoveToPoint( hit.point );

                // Stop focusing any objects.
            } 
        }

        if ( Input.GetMouseButtonDown( 1 ) )
        {
            Ray ray = cam.ScreenPointToRay( Input.mousePosition );
            RaycastHit hit;

            if ( Physics.Raycast( ray, out hit, 100 ) )
            {
                // Check if we hit an interactable.
                // If true, set it as our focus.
            }
        }
    }
}
