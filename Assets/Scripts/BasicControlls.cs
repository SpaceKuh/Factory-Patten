using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControlls : ShipContollProvides
{
    private SpaceShip ship;
    private Transform shipTransform;
    public BasicControlls() { }
    public void Initialize(ShipControllRequires _ship)
    {
        ship = _ship.GetReference();
        shipTransform = ship.GetGameObject().transform;
    }
    private void Move(Vector3 _direction)
    {
        shipTransform.Translate(_direction * (Time.deltaTime * ship.GetSpeed()));
    }

    public void UpdateControlls()
    {
        if (Input.GetKey(KeyCode.A))
            Move(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            Move(Vector3.right);
 
    }
}
