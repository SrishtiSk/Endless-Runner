using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;



    //public GameObject gameover;
    //private bool gameoverStatus = false;

    public void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            if (other.CompareTag("Obstacle"))
            {
                score++;
          //  Debug.Log("score: " + score);
            }
        
    }
}
