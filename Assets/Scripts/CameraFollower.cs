using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
public class CameraFollower : MonoBehaviour
{
    private Transform _cameraTransform;
    [SerializeField] private float _offset; 
    
    public float _smoothTime = 0.3F;
    private Vector3 _velocity = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        _cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(transform.position.x + _offset, _cameraTransform.position.y, _cameraTransform.position.z);
        _cameraTransform.position = Vector3.SmoothDamp(_cameraTransform.position, targetPosition, ref _velocity, _smoothTime);
        
        Scoring.SetDistance(transform.position.x);
    }
}
