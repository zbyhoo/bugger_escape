using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Transform _cameraTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        _cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _cameraTransform.position = new Vector3(_target.position.x, _cameraTransform.position.y, _cameraTransform.position.z);
    }
}
