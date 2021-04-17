using System;
using System.Collections;
using System.Collections.Generic;
using gameManager;
using inputMaster;
using UnityEngine;
using unitData;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public PlayerUnit playerUnit;
    [SerializeField]private float health;
    [SerializeField] private float speed;
    [SerializeField] private GameManager gmManager;
    private InputMaster playerInput;
    

    private Rigidbody2D bod2d;
   
    
    
    private void Awake()
    {
        gmManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        bod2d = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        playerInput = gmManager.playerInput;
        health = playerUnit.health;
        speed = playerUnit.speed;
    }

   
  
    public void FixedUpdate()
    {
        BaseMovement();
        
        health = playerUnit.health;
        speed = playerUnit.speed;
    }

    private void BaseMovement()
    {
        Vector2 moveInput = playerInput.BaseMovement.Move.ReadValue<Vector2>();
        bod2d.velocity = moveInput * speed;
    }

    
    
    
}
