using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
[RequireComponent(typeof(ARRaycastManager))]
public class ButtonSpawn : MonoBehaviour
{
    [SerializeField]
    private Button playButton;

    [SerializeField]
    private Button careButton;

    [SerializeField]
    private Button commandButton;

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

        playButton.onClick.AddListener(() => CreateBowl());
        careButton.onClick.AddListener(() => CreateRope());
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
            placedObject = Instantiate(placedPrefab, arPlane.transform.position, Quaternion.identity);
        }
    }

      private void CreateBowl()
    {
           buttonObject1 = Instantiate(placedBowl, placedPrefab.transform.position, Quaternion.identity);

    }

      private void CreateRope()
    {
            buttonObject2 = Instantiate(placedRope, placedPrefab.transform.position, Quaternion.identity);
        

    }
    


}