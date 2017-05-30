using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour {
   
 //   public GameController gameController;
    Animator animator;
    GameController gameController;
    private bool gameOver;
    void Start()
    {
        animator = GetComponent<Animator>();
        gameOver = false;
    }
    void OnCollisionEnter(Collision other)
    {
        // End the game if an enemy not in the dying state hits us.
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit");
         //   MoveEnemy en = other.gameObject.GetComponent<MoveEnemy>();
            animator.SetBool("isDead", true);
            Destroy(other.gameObject);
            gameController.GetComponent<GameController>().GameOver(true);

        }
    }
   
}
  

