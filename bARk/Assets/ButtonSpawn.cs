using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
[RequireComponent(typeof(ARRaycastManager))]
public class ButtonSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject placedPrefab;
    private GameObject placedObject;
  
    

    [SerializeField]
    private ARPlaneManager arPlaneManager;

    private ARRaycastManager arRaycastManager;

      private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake() 
    {
    
        arRaycastManager = GetComponent<ARRaycastManager>();
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
    }

     private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null && placedObject == null)
        {
            ARPlane arPlane = args.added[0];
            placedObject = Instantiate(placedPrefab, arPlane.transform.position, Quaternion.Euler(0, -190, 0));
        }
    }
 
   
}