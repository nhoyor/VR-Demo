﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
   public void Red()
   {
       GetComponent<Renderer>().material.color = Color.red;
   }

   public void Blue()
   {
       GetComponent<Renderer>().material.color = Color.blue;
   }
   
   public void Black()
   {
       GetComponent<Renderer>().material.color = Color.black;
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
