using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksAnimationScript : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        anim.SetTrigger("books_trig");
    }
}
