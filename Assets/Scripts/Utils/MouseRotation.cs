using System.Collections;
using System.Collections.Generic;
using gameManager;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{

    private GameManager gmManager;

    
    // Start is called before the first frame update
    void Start()
    {
        gmManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
            var mouse = gmManager.playerInput.BaseMovement.MousePos.ReadValue<Vector2>();
            var screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
            mouse.x -= screenPoint.x;
            mouse.y -= screenPoint.y;
            var angle = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));
            if (angle > 90 && angle < 190 || angle < -90 && angle > -190) {this.transform.localScale = new Vector3(1,-1,1);} else {this.transform.localScale = new Vector3(1,1,1);}
            
    }
}
