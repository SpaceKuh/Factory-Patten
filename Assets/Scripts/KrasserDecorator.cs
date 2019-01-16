using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrasserDecorator : ShipDecorator
{
    private BulletFactory bulletFactory;
    public KrasserDecorator(PrimaryAttackProvides _baseAttack)
    {
        bulletFactory = BulletFactory.GetInstance();
		baseAttack = _baseAttack;
    }

    public override void Shoot()
    {
        baseAttack.Shoot();
        Bullet _bullet = bulletFactory.GetBasicBullet();
        _bullet.SetPosition(ship.GetPrimaryWeaponPosition() + Vector3.right);
    }

    public override void UpdatePrimaryAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shoot();
    }
}
