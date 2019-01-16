using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControlls : ShipContollProvides
{
    private SpaceShip ship;
    private Transform shipTransform;
    private Vector3 currentVelocity = Vector3.zero;

    void ShipContollProvides.Initialize(ShipControllRequires _ship)
    {
        ship = _ship.GetReference();
        shipTransform = ship.GetGameObject().transform;
    }

    void ShipContollProvides.UpdateControlls()
    {

        if (Input.GetKey(KeyCode.A))
            TiltShip(10f);
        if (Input.GetKey(KeyCode.D))
            TiltShip(-10f);

        Move();
    }

    private void Move()
    {
        currentVelocity = new Vector3(0, 1, 0);
        shipTransform.Translate(currentVelocity * (Time.deltaTime * ship.GetSpeed()));
    }

    private Vector3 rotateVectorCache = Vector2.zero;
    private void TiltShip(float _angle)
    {
        rotateVectorCache.Set(rotateVectorCache.x, rotateVectorCache.y, _angle);
        shipTransform.Rotate(rotateVectorCache * (Time.deltaTime * 10));
    }
}