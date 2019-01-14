using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager
{
    private static Gamemanager instance;
    private List<GameBehaviour> behaviours;
    private List<GameBehaviour> deletedBehaviours;
    private const int GarbageThreshold = 200;
    // Use this for initialization

    private Gamemanager()
    {
        behaviours = new List<GameBehaviour>();
        deletedBehaviours = new List<GameBehaviour>();
    }

    public static Gamemanager GetInstance()
    {
        if (instance == null)
            instance = new Gamemanager();
        return instance;
    }

    public void Register(GameBehaviour _behaviour)
    {
        if (!behaviours.Contains(_behaviour))
            behaviours.Add(_behaviour);
    }

    public void Remove(GameBehaviour _behaviour)
    {
        behaviours.Remove(_behaviour);
        deletedBehaviours.Add(_behaviour);
    }

    private void CleanUpDeletedObjects()
    {
        for (int i = 0; i < deletedBehaviours.Count; i++)
        {
            MonoBehaviour.Destroy(deletedBehaviours[i].GetGameObject());
            deletedBehaviours.Remove(deletedBehaviours[i]);
        }

    }

    public void Gameloop()
    {
        for (int i = 0; i < behaviours.Count; i++)
        {
            behaviours[i].Update();
        }
        if (deletedBehaviours.Count > GarbageThreshold)
            CleanUpDeletedObjects();
    }

}
