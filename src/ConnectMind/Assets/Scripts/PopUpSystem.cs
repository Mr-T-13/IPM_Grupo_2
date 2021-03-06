﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{

    public GameObject prefab;
    private Transform canvas;
    private GameObject panel;
    public GameObject toDestroy;
    private GameObject principalCanvas;

    private void Start()
    {
        principalCanvas = GameObject.Find("Canvas");

    }
    public void popUpWork()
    {
        canvas = transform.parent;


        if (canvas != principalCanvas  || canvas.name == "PopUpNormal(Clone)" || canvas.name != "PopUpDificil(Clone")
        {
            canvas = principalCanvas.transform;

        }
        if(transform.name=="Boton_minijuego")
        {
            canvas = transform.parent;
        }
        
        panel = Instantiate(prefab, canvas);
    }

    public void popUpDestroy()
    {
        Destroy(toDestroy);
    }
}
