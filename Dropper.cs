using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int droptime = 3;
    MeshRenderer randarer;
    Rigidbody rigi;
    void Start()
    {
        randarer = GetComponent<MeshRenderer>();
       randarer.enabled = false;
        rigi = GetComponent<Rigidbody>();
        rigi.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time>droptime)
        {
            randarer.enabled = true; 
            rigi.useGravity = true;

        }
    }
}
