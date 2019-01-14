using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsWrapper
{

    private PhysicsWrapper() { }
    public static void InitPhysics(ColliderRequires _obj, bool _isTrigger = true)
    {
        Rigidbody2D _body = _obj.GetGameObject().AddComponent<Rigidbody2D>();
        _body.isKinematic = true;
        _body.gravityScale = 0;
        _body.angularDrag = 0;
        _body.drag = 0;

        BoxCollider2D _collider = _obj.GetGameObject().AddComponent<BoxCollider2D>();
        _collider.isTrigger = _isTrigger;

        _obj.GetGameObject().AddComponent<CollisionHandler>().SetCollidingObject(_obj);

    }

    public static void RemovePhysics(ColliderRequires _obj)
    {
        try
        {
            MonoBehaviour.Destroy(_obj.GetGameObject().GetComponent<Rigidbody2D>());
            MonoBehaviour.Destroy(_obj.GetGameObject().GetComponent<BoxCollider2D>());
            MonoBehaviour.Destroy(_obj.GetGameObject().GetComponent<CollisionHandler>());
        }
        catch (System.Exception)
        {
            Debug.LogWarning(_obj.GetGameObject().name + " is trying to remove Physics without but cannot.");
        }

    }
}
