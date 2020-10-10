using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Transform cameraTransform;
    [SerializeField] float cameraDistanceZ;
    [SerializeField] float cameraDistanceY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCameraPosion();
    }

    void UpdateCameraPosion()
    {
        transform.position = playerTransform.position - cameraTransform.forward * cameraDistanceZ 
                           + cameraTransform.up * cameraDistanceY;
    }
}
