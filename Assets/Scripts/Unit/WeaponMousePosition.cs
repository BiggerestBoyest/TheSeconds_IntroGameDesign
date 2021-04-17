using System.Collections;
using System.Collections.Generic;
using gameManager;
using inputMaster;
using UnityEngine;

public class WeaponMousePosition : MonoBehaviour
{
 
    private Vector3 ve3PlayerPos;
    [SerializeField] private float radius;
    [SerializeField] private float speed;

    private Vector3 ve3CursorPos;
    private Vector3 ve3MousePos;


    private GameManager gmManager;
    private GameObject player;
    
    


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gmManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePosition = gmManager.playerInput.BaseMovement.MousePos.ReadValue<Vector2>();
        
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(mousePosition);
        cursorPos.z = 10;
        
        ve3PlayerPos = player.transform.position;

        Vector3 playerToCursor = cursorPos - ve3PlayerPos;
        Vector3 dir = playerToCursor.normalized;
        Vector3 cursorVector = dir * radius;

        if (playerToCursor.magnitude < cursorVector.magnitude)
        {
            cursorVector = playerToCursor;

        }
        
            transform.position = ve3PlayerPos - cursorVector;
            ve3CursorPos = ve3PlayerPos - cursorVector;
            ve3CursorPos.z = 10f;
        
    
  
      
    }


    public Vector3 getCursorPos() 
    {
        return ve3CursorPos;
    }

    public void setRadius(int newAmount) 
    {
        radius = newAmount;
    }
    

    

}
