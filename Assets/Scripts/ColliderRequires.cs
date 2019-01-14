using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ColliderRequires
{
    void OnCollisionEnter2D(Collision2D other);
    void OnTriggerEnter2D(Collider2D other);
    GameObject GetGameObject();

}
