using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipDecorator : PrimaryAttackProvides
{
	protected SpaceShip ship;
	protected PrimaryAttackProvides baseAttack;
    public void Initialize(SpaceShip _spaceship)
	{
		ship = _spaceship;
	}
    public abstract void Shoot();
    public abstract void UpdatePrimaryAttack();
}
