using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private CharacterController charactercontroller;


    public float Speed = 5f;

    private void Start()
    {
        charactercontroller = GetComponent<CharacterController>();


    }


    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        charactercontroller.Move(move * Time.deltaTime * Speed);

    }

}
