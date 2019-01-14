using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameBehaviour : ColliderRequires
{
    private GameObject m_gameobject;
    protected Transform m_transform;
    protected Gamemanager gamemanager;
    protected Collider2D hitbox;

    public GameBehaviour()
    {
        m_gameobject = new GameObject();
        m_transform = m_gameobject.transform;
        gamemanager = Gamemanager.GetInstance();
        gamemanager.Register(this);
        Awake();
        Start();
    }

    protected void Awake() { }

    // Use this for initialization
    protected void Start() { }

    // Update is called once per frame
    public abstract void Update();
    public GameObject GetGameObject()
    {
        return m_gameobject;
    }

    public void Destroy()
    {
        gamemanager.Remove(this);
        this.m_gameobject.SetActive(false);
    }

    public void InitializeCollider()
    {
        GetGameObject().AddComponent<BoxCollider2D>();
    }

    public virtual void OnCollisionEnter2D(Collision2D other) { }
    public virtual void OnTriggerEnter2D(Collider2D other) { }
    public virtual Collider2D GetCollider()
    {
        return hitbox;
    }
}
