﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameBehaviour
{
    private GameObject m_gameobject;
    protected Transform m_transform;
    protected Gamemanager gamemanager;
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
}
