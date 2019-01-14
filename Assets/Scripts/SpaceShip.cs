using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SpaceShip : GameBehaviour, PrimaryAttackRequires, ShipControllRequires
{
    private PrimaryAttackProvides primaryAttack;
    private ShipContollProvides controlls;
    private float movementSpeed = 3.5f;
    public SpaceShip() : base()
    {
        Debug.Log("I have been created");
        m_transform.gameObject.AddComponent<SpriteRenderer>();
        m_transform.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("spaceship");
        PhysicsWrapper.InitPhysics(this);
    }
    public override void Update()
    {
        controlls.UpdateControlls();
        primaryAttack.UpdatePrimaryAttack();
        if (Input.GetKeyDown(KeyCode.T))
            Destroy();
    }

    public SpaceShip GetReference()
    {
        return this;
    }

    public Vector3 GetPrimaryWeaponPosition()
    {
        return m_transform.position + Vector3.up;
    }

    public void SetPrimaryAttack(PrimaryAttackProvides _primaryAttack)
    {
        primaryAttack = _primaryAttack;
        primaryAttack.Initialize(this);
    }

    public void SetShipControlls(ShipContollProvides _shipControlls)
    {
        controlls = _shipControlls;
        controlls.Initialize(this);
    }
    public float GetSpeed()
    {
        return movementSpeed;
    }

    public override void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collided");
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered");
    }

}
