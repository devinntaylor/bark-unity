using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class animationScript : MonoBehaviour
{ 
    private Animator Anim;

    [SerializeField]
    public Button careButton;

    [SerializeField]
    public Button playButton;

    [SerializeField]
    public Button commandButton;

    bool waitActive = false;
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>(); 

        careButton.onClick.AddListener(careClick);
        playButton.onClick.AddListener(playClick);
        commandButton.onClick.AddListener(commandClick);
    }
IEnumerator Wait(){
     waitActive = true;
     yield return new WaitForSeconds (3.0f);
     waitActive = false;
 }

    void careClick()
    {
         Anim.SetBool("Arm_Dog|Drink", true);
        StartCoroutine(Wait()); 
         Anim.SetBool("Arm_Dog|Drink", false);
    }

    void playClick()
    {
         Anim.SetBool("Arm_Dog|Agression", true);
        StartCoroutine(Wait()); 
         Anim.SetBool("Arm_Dog|Agression", false);
    }
    void commandClick()
    {
         Anim.SetBool("Arm_Dog|Sitting", true);
         StartCoroutine(Wait()); 
         Anim.SetBool("Arm_Dog|Sitting", false);
    }

}

 
 