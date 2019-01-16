using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Gamemanager gamemanager;
    private MainCamera main_camera;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        gamemanager = Gamemanager.GetInstance();
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void CreateGame()
    {
        GameObject _gameobject = new GameObject();
        _gameobject.AddComponent<Main>();
    }
    // Use this for initialization
    void Start()
    {
        ShipFactory shipFactory = new ShipFactory();
        SpaceShip basicShip = shipFactory.BuildBasicShip();
        Camera.main.GetComponent<SmoothFollow2D>().m_Target = basicShip.GetGameObject().transform;
        WorldGenerator world_generator = WorldGenerator.GetInstance();
        world_generator.GenerateWorld();
    }

    // Update is called once per frame
    void Update()
    {
        gamemanager.Gameloop();
    }
}
