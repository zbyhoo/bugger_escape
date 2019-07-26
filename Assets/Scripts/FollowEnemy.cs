using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    [SerializeField] private BlobSizeSwitcher _switcher;
    public float _smoothTime = 0.3F;
    private Vector3 _velocity = Vector3.zero;

    void Update()
    {
        JellySprite current = _switcher._blobs.FirstOrDefault(t => t.gameObject.activeSelf);
        if (current == null)
        {
            return;
        }
        
        Vector3 targetPosition = new Vector3(transform.position.x,  current.transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
    }
}
