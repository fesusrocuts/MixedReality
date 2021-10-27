using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
//https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@2.1/manual/trackable-managers.html
//gradle version 5.6.4 - android

public class ImageDetectorV1 : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;
    
    private void Awake()
    {
        //_arTrackedImageManager = findObjectOfType<ARTrackedImageManager>();
        //_arTrackedImageManager = GetComponent<ARTrackedImageManager>();
        _arTrackedImageManager = GameObject.FindGameObjectWithTag("Respawn").GetComponent<ARTrackedImageManager>();
    }
    
    void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChange;
    }
    
    void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChange;
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
