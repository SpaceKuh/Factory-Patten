using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ColliderProvides
{
    void Initialize(ColliderRequires collision_object);
    // void OnTriggerEnter2D(Collider2D other);
    // void OnCollisionEnter2D(Collision2D other);
}
