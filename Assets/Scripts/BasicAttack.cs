using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : PrimaryAttackProvides
{
    private SpaceShip ship;
    private BulletFactory bulletFactory;
    private List<Bullet> bullets;
    public BasicAttack()
    {
        bullets = new List<Bullet>();
        bulletFactory = BulletFactory.GetInstance();
    }
    public void Initialize(SpaceShip _spaceship)
    {
        ship = _spaceship;
    }

    public void Shoot()
    {
		Bullet _bullet = bulletFactory.GetBasicBullet();
        _bullet.SetPosition(ship.GetPrimaryWeaponPosition());
    }

    public void UpdatePrimaryAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }

}
