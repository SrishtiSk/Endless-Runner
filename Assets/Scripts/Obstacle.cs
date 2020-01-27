using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obsEffect;
    public int damage = 1;
    public float obsSpeed;
    public GameObject explosionSound;
   
    private void Update()
    {
        transform.Translate(Vector2.left * obsSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D obsCollision)
    {
        if (obsCollision.CompareTag("Player"))
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            Instantiate(obsEffect, transform.position, Quaternion.identity);
  
            obsCollision.GetComponent<Player>().health = obsCollision.GetComponent<Player>().health -= damage; ;
           // Debug.Log("health "+obsCollision.GetComponent<Player>().health);
            Destroy(gameObject);
        }
        
    }
}
