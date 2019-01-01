using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PrimaryAttackProvides{

	void Shoot();
	void Initialize(SpaceShip _spaceship);
	void UpdatePrimaryAttack();
}
