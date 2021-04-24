using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Variable called runSpeed is the speed that players running through the road.
    //dodgeSpeed is the speed that player goes left-right.
    public float runSpeed,dodgeSpeed = 6f;
    float xInput;
    void Start()
    {
        
    }

   
    void Update()
    {
        MouseInput();
        transform.Translate(xInput * dodgeSpeed * Time.deltaTime, 0, (-1)*runSpeed * Time.deltaTime);
        if (transform.position.y <= 0)
        {
           //Makes player lose if they fall.
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    
    void MouseInput()
    {
        //Checks if players holding the mouse button on the right side of the screen or left.
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Input.mousePosition;
            float midScreen = Screen.width / 2;
            if (touchPos.x < midScreen)
            {
                xInput = 1;
                
            }
            if (touchPos.x > midScreen)
            {
                xInput = -1;
                
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            xInput = 0;
        }
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Finish")
        {
            runSpeed = 0;
            dodgeSpeed = 0;
        }
    }
}
