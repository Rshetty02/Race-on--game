﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyBox : MonoBehaviour
{

    public Material skybox1;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skybox1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
