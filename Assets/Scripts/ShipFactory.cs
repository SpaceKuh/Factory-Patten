using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFactory
{

    public ShipFactory() { }

    public SpaceShip BuildBasicShip()
    {
        SpaceShip newShip = new SpaceShip();
        newShip.SetPrimaryAttack(new BasicAttack());
        newShip.SetShipControlls(new BasicControlls());

        return newShip;
    }
}
