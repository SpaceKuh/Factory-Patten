using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory
{
    private static BulletFactory instance;
    private BulletFactory() { }
    public static BulletFactory GetInstance()
    {
        if (instance == null)
            instance = new BulletFactory();
        return instance;
    }
    public BasicBullet GetBasicBullet()
    {
        BasicBullet _bullet = new BasicBullet();
		GameObject _go = _bullet.GetGameObject();
        _go.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rock");
        _go.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        return _bullet;
    }
}
