using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
[RequireComponent(typeof(ARRaycastManager))]
public class ButtonSpawn : MonoBehaviour
{
    [SerializeField]
    public Button playButton;
    Image  playButtonImg;
    public Image playImage;
    public Image playSecondImage;

   

    [SerializeField]
    public Button careButton;

    [SerializeField]
    public Button commandButton;

    [SerializeField]
    private GameObject placedPrefab;

    private GameObject placedObject;

    [SerializeField]
    private GameObject placedBowl;

    private GameObject buttonObject1;

    [SerializeField]
    private GameObject placedRope;

    private GameObject buttonObject2;

    [SerializeField]
    private ARPlaneManager arPlaneManager;

    private ARRaycastManager arRaycastManager;

      private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake() 
    {
   Button playbtn = playButton.GetComponent<Button>();
        Button carebtn = careButton.GetComponent<Button>();

        arRaycastManager = GetComponent<ARRaycastManager>();
        


        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
    }

     private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null && placedObject == null)
        {
            ARPlane arPlane = args.added[0];
            placedObject = Instantiate(placedPrefab, arPlane.transform.position, Quaternion.Euler(45, 0, 0));
        }
    }
 void Update()
    {
           playButtonImg = playButton.GetComponent<Image> ();

 

        // playButton.onClick.AddListener(() => CreateRope());
        // careButton.onClick.AddListener(() => CreateBowl());
		

           // commandButton.onClick.AddListener(() => CreateObject());

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                var touchPosition = touch.position;

                bool isOverUI = touchPosition.IsPointOverUIObject();
                
                if(isOverUI)
                {

                     if (playButtonImg == playImage)
                          playButtonImg = playSecondImage;
                    else {
                    playButtonImg = playImage;
                }
                       
                    //  buttonObject1 = Instantiate(placedBowl,                 placedPrefab.transform.position, Quaternion.identity);

    

                    //   buttonObject2 = Instantiate(placedRope, placedPrefab.transform.position, Quaternion.identity);
                            
                        
                }

            }
        }
    }
   
}