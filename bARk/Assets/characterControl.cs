using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class characterControl : MonoBehaviour
{
    public Animator Anim; 
    

    public GameObject playOpen;
    public GameObject careOpen;
    public GameObject commandOpen;

    void Start()
    {
        playOpen.SetActive(false); 
      commandOpen.SetActive(false); 
      careOpen.SetActive(false); 
        
      
    }

    public void play(){
         if (playOpen.activeSelf){
            Anim.SetTrigger("P");
            playOpen.SetActive(false); 
            Debug.Log("anim/play button close");
         }
         else{
            playOpen.SetActive(true);
            Debug.Log("play button open");
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
