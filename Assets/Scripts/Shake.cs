using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public Animator camAmin;
    
    public void CamShake()
    {
        camAmin.SetTrigger("shake");
       // Debug.Log("Shaking");  //it works!
    }
}
