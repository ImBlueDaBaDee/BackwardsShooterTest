using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().GameOver();
            //if thouched by an enemy, player is destroyed and the game ends.
        }
        if (collisionInfo.collider.tag == "Finish")
        {
            anim.SetBool("isFinish", true);
            FindObjectOfType<GameManager>().YouWin();
            //if player touches the finish line, game ends.
        }
    }
    
}
