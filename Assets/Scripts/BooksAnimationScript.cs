using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksAnimationScript : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        anim.SetTrigger("BooksTrig");
    }
}
