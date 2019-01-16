using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControlls : ShipContollProvides
{
    private SpaceShip ship;
    private Transform shipTransform;
    private MoveCommand moveRight;
    private MoveCommand moveLeft;
    private MoveCommand moveUp;
    private MoveCommand moveDown;
    private CommandManager commandManager;
    public BasicControlls()
    {
        commandManager = CommandManager.GetInstance();
    }
    public void Initialize(ShipControllRequires _ship)
    {
        ship = _ship.GetReference();
        shipTransform = ship.GetGameObject().transform;
        moveRight = new MoveCommand(ship, Vector3.right);
        moveLeft = new MoveCommand(ship, Vector3.left);
        moveUp = new MoveCommand(ship, Vector3.up);
        moveDown = new MoveCommand(ship, Vector3.down);
    }
    private void Move(Vector3 _direction)
    {
        shipTransform.Translate(_direction * (Time.deltaTime * ship.GetSpeed()));
    }

    public void UpdateControlls()
    {
        if (Input.GetKey(KeyCode.A))
            moveLeft.Execute();
        if (Input.GetKey(KeyCode.D))
            moveRight.Execute();
        if (Input.GetKey(KeyCode.W))
            moveUp.Execute();
        if (Input.GetKey(KeyCode.S))
            moveDown.Execute();

        if (Input.GetKey(KeyCode.Z))
            commandManager.UndoLastCommand();



    }
}
