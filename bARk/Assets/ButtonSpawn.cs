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

    void Awake() 
    {

        arRaycastManager = GetComponent<ARRaycastManager>();
        
        Button playbtn = playButton.GetComponent<Button>();
        Button carebtn = careButton.GetComponent<Button>();

		playbtn.onClick.AddListener(CreateRope);
        carebtn.onClick.AddListener(CreateBowl);

        // commandButton.onClick.AddListener(() => CreateObject());

        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
    }
    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;

        return false;
    }

     private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null && placedObject == null)
        {
            ARPlane arPlane = args.added[0];
            placedObject = Instantiate(placedPrefab, arPlane.transform.position, Quaternion.Euler(180, 180, 0));
        }
    }

      void CreateBowl()
    {
           buttonObject1 = Instantiate(placedBowl, placedPrefab.transform.position, Quaternion.identity);

    }

      void CreateRope()
    {
            buttonObject2 = Instantiate(placedRope, placedPrefab.transform.position, Quaternion.identity);
        

    }
    
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

}