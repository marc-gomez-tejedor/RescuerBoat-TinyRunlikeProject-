using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TextBehavior : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField]
    private int maxScore;

    public void Start()
    {
        text.text = "0/" + maxScore;
    }

    public void TextBehav(int score)
    {
        text.text = score + "/" + maxScore;
    }
}
