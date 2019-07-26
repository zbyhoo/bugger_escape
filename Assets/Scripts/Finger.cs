using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finger : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _body;
    [SerializeField] private Vector2 _velocity;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.enabled == false)
        {
            return;
        }

        if (other.gameObject.name.StartsWith("BlobSize"))
        {
            SceneManager.LoadScene("End");
        }
    }

    private void Start()
    {
        _body.velocity = _velocity;
    }
}
