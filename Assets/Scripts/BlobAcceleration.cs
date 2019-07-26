using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
public class BlobAcceleration : MonoBehaviour
{
    [SerializeField] private float _targetSpeed;
    [SerializeField] private float _forceMult;
    [SerializeField] private float _forceMax;

    [SerializeField] private UnityJellySprite _body;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float force = (_targetSpeed - _body.GetCentralPointVelocity().x) * _forceMult;

        if (force > _forceMax)
        {
            force = _forceMax;
        }
        
        _body.AddForce(new Vector2(force, 0));
    }
}
