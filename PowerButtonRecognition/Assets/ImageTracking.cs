using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using TMPro; 

public class ImageTracking : MonoBehaviour
{

    private ARTrackedImage trackedImage; 
    private TextMeshProUGUI headerText;

    void Awake()
    {
        trackedImage = GetComponent<ARTrackedImage>();
        headerText = GetComponentInChildren<TextMeshProUGUI>(); 
    }

    void Start()
    {
        headerText.text = trackedImage.referenceImage.name; 
    }
}
