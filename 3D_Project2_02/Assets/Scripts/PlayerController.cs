using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private GameObject Player;
    [SerializeField] private PlayerInput MPI;
    private Rigidbody rb;

    private InputAction jump;
    private InputAction restart;
    private InputAction quit;

    private Vector3 pMovement;
    [SerializeField] private int PlayerSpeed;

    [SerializeField] private int JumpForce;
    private bool AllowJump;

    private void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
        MPI.currentActionMap.Enable();
        jump = MPI.currentActionMap.FindAction("Jump");
        jump.started += JumpStarted;
        quit = MPI.currentActionMap.FindAction("Quit");
        quit.started += QuitStarted;
        restart = MPI.currentActionMap.FindAction("Restart");
        restart.started += RestartStarted;
    }

  

    private void OnMove(InputValue inputVector2)
    {
        //Saving and reading the Vector2
        Vector2 input = inputVector2.Get<Vector2>();
        pMovement.x = input.x * PlayerSpeed;
        pMovement.z = input.y * PlayerSpeed;
    }

    private void JumpStarted(InputAction.CallbackContext context)
    {
        if (AllowJump == true)
        {
            AllowJump = false;
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.y);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            AllowJump = true;
        }
    }

    private void Update()
    {
        rb.velocity = new Vector3(pMovement.x, rb.velocity.y, pMovement.z);
    }

   

    private void QuitStarted(InputAction.CallbackContext context)
    {
        Application.Quit();
    }
    private void RestartStarted(InputAction.CallbackContext context)
    {
        SceneManager.LoadScene(0);
    }

    private void OnDestroy()
    {
        jump.started -= JumpStarted;
        quit.started -= QuitStarted;
    }
}
