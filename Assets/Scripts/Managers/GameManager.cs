using System;
using System.Collections;
using System.Collections.Generic;
using inputMaster;
using UnityEngine;

namespace gameManager
{
    public class GameManager : MonoBehaviour
    {


        public InputMaster playerInput;
        

        public void Awake()
        {
            playerInput = new InputMaster();
        }
        
        private void OnEnable()
        {
            playerInput.Enable();  
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }
        
        
    }
    
  

    

}
