using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : GameBehaviour
{
    private static MainCamera instance;
    private Camera camera;
    private Transform transform;
    private Transform player_transform;
    private Vector3 posCache;

    private MainCamera()
    {
        camera = Camera.main;
        transform = camera.transform;
    }

    public static MainCamera GetInstance()
    {
        if (instance == null)
            instance = new MainCamera();
        return instance;
    }

    public void SetTarget(Transform _target)
    {
        player_transform = _target;
    }

    public override void Update()
    {
        if (player_transform == null)
            return;

        posCache.Set(player_transform.position.x, player_transform.position.y, -10);
        transform.position = posCache;
    }
}