using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollider : MonoBehaviour
{
    [SerializeField] private ParticleSystem _part;
    [SerializeField] private List<ParticleCollisionEvent> _collisionEvents;
    
    ParticleSystem.Particle[] _particles;

//    void OnParticleCollision(GameObject other)
//    {
//        int numCollisionEvents = _part.GetCollisionEvents(other, _collisionEvents);
//
//        Rigidbody rb = other.GetComponent<Rigidbody>();
//        int i = 0;
//
//        _part.GetParticles(_particles);
//
//        foreach (var p in _particles)
//        {
//        }
//        
//        foreach (var e in _collisionEvents)
//        {
//            e.colliderComponent
//        }
//
//        while (i < numCollisionEvents)
//        {
//            if (rb)
//            {
//                Vector3 pos = collisionEvents[i].intersection;
//                Vector3 force = collisionEvents[i].velocity * 10;
//                rb.AddForce(force);
//            }
//            i++;
//        }
//    }
}
