using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBullet : GameBehaviour, Bullet
{
	private float speed = 2.5f;
	public BasicBullet():base()
	{

	}
    public void OnHit()
    {
        
    }

    public override void Update()
    {
        m_transform.Translate(Vector3.up*(speed*Time.deltaTime));
    }

	public void SetPosition(Vector3 _position)
	{
		m_transform.position = _position;
	}
}
