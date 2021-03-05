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

    void Start()
    {
        Anim = gameObject.GetComponent<Animator>(); 

        careButton.onClick.AddListener(careClick);
        playButton.onClick.AddListener(playClick);
        commandButton.onClick.AddListener(commandClick);
    }

    void careClick()
    {
         Anim.SetBool("Arm_Dog|Drink", true);
         Debug.Log("Care clicked");
    }

    void playClick()
    {
         Anim.SetBool("Arm_Dog|Agression", true);
         Debug.Log("Play clicked");
    }
    void commandClick()
    {
         Anim.SetBool("Arm_Dog|Sitting", true);
         Debug.Log("Command clicked");
    }

}

 
 