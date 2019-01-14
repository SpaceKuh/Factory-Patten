using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    private ColliderRequires colliding_object;

    private void OnTriggerEnter2D(Collider2D other)
    {
        colliding_object.OnTriggerEnter2D(other);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        colliding_object.OnCollisionEnter2D(other);
    }

    public void SetCollidingObject(ColliderRequires _colliding_object)
    {
        colliding_object = _colliding_object;
    }
}
