using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animation;

    public void Init()
    {
    }

    private void Start()
    {
        _animation = gameObject.GetComponent<Animator>();
    }
    public void Dying()
    {
        _animation.SetTrigger("dying");
    }
}



