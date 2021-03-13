using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class characterControl : MonoBehaviour
{
    Animator Anim; 
    

    public GameObject playOpen;
    public GameObject careOpen;
    public GameObject commandOpen;

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    public void play(){
         if (playOpen.activeSelf){
            Anim.SetTrigger("P");
            playOpen.SetActive(false); 
         }
         else{
            playOpen.SetActive(true);
         }
    }

    public void command(){
       if (commandOpen.activeSelf){
            Anim.SetTrigger("S");
            commandOpen.SetActive(false); 
         }
         else{
            commandOpen.SetActive(true);
         }
    }

    public void care(){
         if (careOpen.activeSelf){
            Anim.SetTrigger("D");
            careOpen.SetActive(false); 
         }
         else{
            careOpen.SetActive(true);
         }
    }

}
