using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    private Vector3 direction;
    private Vector3 traveledVector;
    private SpaceShip ship;
    private Transform shipTransform;

    public MoveCommand(SpaceShip _ship, Vector3 _direction) : base()
    {
        direction = _direction;
        ship = _ship;
        shipTransform = ship.GetGameObject().transform;
        commandManager = CommandManager.GetInstance();
    }

    public void SetTraveledDistance(Vector3 _traveldDistance)
    {
        traveledVector = _traveldDistance;
    }

    public override void Execute()
    {
        Vector3 _moveVector = new Vector3(direction.x, direction.y, direction.z);
        _moveVector = _moveVector * (ship.GetSpeed() * Time.deltaTime);
        shipTransform.Translate(_moveVector);
        traveledVector = _moveVector;

        MoveCommand executedCommand = new MoveCommand(this.ship, this.direction);
        executedCommand.SetTraveledDistance(this.traveledVector);
        commandManager.Subscribe(executedCommand);
    }

    public override void Undo()
    {
        if (traveledVector != null)
            shipTransform.Translate(-traveledVector);
    }
}