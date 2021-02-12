using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ButtonClick : MonoBehaviour
{
    public GameObject Bowl;

    public void AddObject()
{
    Instantiate(Bowl, Vector3.zero,  Quaternion.Euler(180, 180, 0));
}
}
