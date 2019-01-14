using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour, ColliderProvides
{
    protected ColliderRequires collision_object;

    public void Initialize(ColliderRequires _collision_object)
    {
        collision_object = _collision_object;
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("parent collided");
        collision_object.OnCollisionEnter2D(other);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("parent triggered");
        collision_object.OnTriggerEnter2D(other);
    }
}
