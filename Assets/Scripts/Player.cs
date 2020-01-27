using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    
    public float yPosVal;
    public float speed;
    public float maxHeight =3f;
    public float minHeight =-3f;

    public int health = 5;
    public Text healthdisplay;
    public GameObject playerEffect;

    private Shake shake;

    public GameObject gameover;
    public GameObject PopSound;


    public void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();

    }

    // Update is called once per frame
    void Update()
    {

        healthdisplay.text = health.ToString();
        
        if (health <= 0)
        {
            gameover.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            
            Instantiate(playerEffect, transform.position, Quaternion.identity);
            Instantiate(PopSound, transform.position, Quaternion.identity);
            //Instantiate(playerEffect, transform.position, Quaternion.identity);
            shake.CamShake();
            targetPos = new Vector2(transform.position.x, transform.position.y + yPosVal);

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {

            Instantiate(playerEffect, transform.position, Quaternion.identity);
            Instantiate(PopSound, transform.position, Quaternion.identity);
           // Instantiate(playerEffect, transform.position, Quaternion.identity);
            shake.CamShake();
            targetPos = new Vector2(transform.position.x, transform.position.y - yPosVal);
            
        }
    }
}























