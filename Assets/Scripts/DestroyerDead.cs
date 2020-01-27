using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerDead : MonoBehaviour
{
    /* this script removes all the junk game objects ie. the obstacles that are destroyes and
     clones are removed after a time span. this reduces junk and prevents from future lagging of game
     */

    public float lifetime;


    void Start()
    {
        Destroy(gameObject, lifetime);    
    }
    
}
