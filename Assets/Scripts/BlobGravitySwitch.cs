using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;

public class BlobGravitySwitch : MonoBehaviour
{
    [SerializeField] private UnityJellySprite _body;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _body.SwitchGravity();
        }
    }
}
