using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AnchorHUDController : MonoBehaviour
{
    [SerializeField]
    private Sprite imageOn;

    [SerializeField]
    private Sprite imageOff;

    [SerializeField]
    private GameObject boat;
    private Image spriteAnchor;
    private ShootAnchor _anchor;

    void Start()
    {
        spriteAnchor = GetComponent<Image>();
        _anchor = boat.GetComponent<ShootAnchor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_anchor.timer>0) spriteAnchor.sprite = imageOff;
        else spriteAnchor.sprite = imageOn;
    }
}
