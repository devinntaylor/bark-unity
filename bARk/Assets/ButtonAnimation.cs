using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ButtonAnimation : MonoBehaviour
{
    Animator anim;
    public GameObject Husky;

void Start()
    {
        anim = Husky.GetComponentInChildren<Animator>();
    }

  void Update()
    {
            anim.SetTrigger("Active");
    }
    
}



 
    
    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         anim.SetTrigger("Active");
    //     }
    // }


