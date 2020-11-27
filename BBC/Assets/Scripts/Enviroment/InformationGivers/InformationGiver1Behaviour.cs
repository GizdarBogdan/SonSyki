﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationGiver1Behaviour : MonoBehaviour
{
    GameObject button;

    void Start()
    {
        button = GameObject.Find("InformationButton_1");
        button.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
    }
}
