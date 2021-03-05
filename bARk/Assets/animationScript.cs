using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class animationScript : MonoBehaviour
{ 
    private Animator Anim;

   public void Start()
    {
        Anim = gameObject.GetComponent<Animator>(); 
    }

    public void careClick()
    {
         Anim.SetBool("Arm_Dog|Drink", true);
         Debug.Log("Care clicked");
    }

    public void playClick()
    {
         Anim.SetBool("Arm_Dog|Agression", true);
         Debug.Log("Play clicked");
    }
    public void commandClick()
    {
         Anim.SetBool("Arm_Dog|Sitting", true);
         Debug.Log("Command clicked");
    }

}

 
 