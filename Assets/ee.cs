using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ee : MonoBehaviour
{
    Animator ani;
    int a = 0;
    void Start()
    {
        ani = GetComponent<Animator>();
        ani.SetBool("bJump", false);
    }

    // Update is called once per frame
    void Update()
    {
        a += 1;
        Debug.Log(a);
        if(a>500)
        {
            ani.SetBool("bJump", true);
        }
        else
        {
            ani.SetBool("bJump", false);
        }
    }
}
