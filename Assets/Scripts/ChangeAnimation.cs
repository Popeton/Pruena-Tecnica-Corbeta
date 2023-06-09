using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string [] currentAnimation;
    private int number;


    public void  Num(int num)
    {
        number = num;
       
    }
    public void AnimationChange(string name)
    {
        _animator.SetBool(currentAnimation[number], false);
        _animator.SetBool(name, true);
    }

}
