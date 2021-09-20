using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = -1;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits = hits + 1;
            Debug.Log("We have bumped into a wall " + hits + " times");
        }
         
    }
}
