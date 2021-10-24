using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;


public class ImageDetectorV1 : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;

    private void Awake()
    {
        _arTrackedImageManager = findObjectOfType<ARTrackedImageManager>();
    }
    
    void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanges += OnImageChange;
    }
    
    void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanges -= OnImageChange;
    }
    
    void OnImageChange(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
/*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
*/
}
