using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Gamemanager gamemanager;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        gamemanager = Gamemanager.GetInstance();
    }
    // Use this for initialization
    void Start()
    {
        // SpaceShip ship1 = new SpaceShip();
        ShipFactory shipFactory = new ShipFactory();
        SpaceShip basicShip = shipFactory.BuildBasicShip();
    }

    // Update is called once per frame
    void Update()
    {
        gamemanager.Gameloop();
    }
}
