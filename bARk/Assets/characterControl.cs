using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class characterControl : MonoBehaviour
{
    Animator Anim; 
    public int State = 0;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    
    public void animTrig()
    {
        if (State == 0)
        {
            Anim.SetTrigger("P");
            State = 1;
            return;
        }
         if (State == 1)
        {
            Anim.SetTrigger("D");
            State = 2;
            return;
        }
         if (State == 2)
        {
            Anim.SetTrigger("S");
            State = 0;
            return;
        }
    }

}
