﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTheoryBookButtonLevel1Behaviour : MonoBehaviour
{
    public void CloseTheoryBook()
    {
        GameObject player = GameObject.Find("Snowman");
        GameObject theoryBook = GameObject.Find("Panel_TheoryBook");
        GameObject mainThemes = GameObject.Find("Panel_MainThemes");
        GameObject theme1 = GameObject.Find("Panel_Theme1");
        theoryBook.transform.position = theoryBook.GetComponent<TheoryBookBehaviour>().TurnOffPosition;
        mainThemes.transform.position = mainThemes.GetComponent<ThemePanelsBehaviour>().TurnOffPosition;
        theme1.transform.position = theme1.GetComponent<ThemePanelsBehaviour>().TurnOffPosition;
        player.GetComponent<Rigidbody2D>().constraints = ~RigidbodyConstraints2D.FreezePosition;
    }
}
