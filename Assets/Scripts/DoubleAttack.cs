using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleAttack : PrimaryAttackProvides
{
    private SpaceShip ship;
    private BulletFactory bulletFactory;
    public void Initialize(SpaceShip _spaceship)
    {
        ship = _spaceship;
        bulletFactory = BulletFactory.GetInstance();
    }

    public void Shoot()
    {
        Bullet _bullet1 = bulletFactory.GetBasicBullet();
        Bullet _bullet2 = bulletFactory.GetBasicBullet();

        _bullet1.SetPosition(ship.GetPrimaryWeaponPosition() + Vector3.right);
        _bullet2.SetPosition(ship.GetPrimaryWeaponPosition() + Vector3.left);
    }

    public void UpdatePrimaryAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }
}
