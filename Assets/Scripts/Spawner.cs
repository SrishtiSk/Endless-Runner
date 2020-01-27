using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;

    private float timeBtwSpawn;
    public float startTimebBtwSpawn = 1.25f;
    public float decreaseTime = .5f;
    public float minTime = 1f;


    private void Update()
    {
        if(timeBtwSpawn <=0)
        {
            int rand = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimebBtwSpawn;
           if(startTimebBtwSpawn > minTime)
               startTimebBtwSpawn -= decreaseTime;

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }


}
