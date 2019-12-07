using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DogMoves : MonoBehaviour
{
    private Animator animator;
    private int count;
    public System.DateTime time;
    bool patita = false;
    bool muerto=false;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        time = System.DateTime.UtcNow;
    }

 
    private void OnMouseDown()
    {
        Patita();
    }

    private void Patita()
    {
        AnimatorStateInfo a= animator.GetCurrentAnimatorStateInfo(0);
        if(a.IsName("Sentado"))
            animator.SetTrigger("patita");
    }

    public void Muerto()
    {
        AnimatorStateInfo a = animator.GetCurrentAnimatorStateInfo(0);
        if (a.IsName("Sentado"))
            animator.SetTrigger("muerto");
    }

    public void Rodar()
    {
        AnimatorStateInfo a = animator.GetCurrentAnimatorStateInfo(0);
        if (a.IsName("Sentado"))
            animator.SetTrigger("rodar");
    }

    public void DePie()
    {
        AnimatorStateInfo a = animator.GetCurrentAnimatorStateInfo(0);
        if (a.IsName("Sentado"))
            animator.SetTrigger("dePie");
    }

    public void Sentarse()
    {
        AnimatorStateInfo a = animator.GetCurrentAnimatorStateInfo(0);
        if (a.IsName("DePie")||a.IsName("Rodar"))
            animator.SetTrigger("sentarse");
    }
}
