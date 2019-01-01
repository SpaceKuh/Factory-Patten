using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager
{
    private static Gamemanager instance;
    private List<GameBehaviour> behaviours;
    // Use this for initialization

    private Gamemanager()
    {
        behaviours = new List<GameBehaviour>();
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
	}

	public void Gameloop()
	{
		for (int i = 0; i < behaviours.Count; i++)
		{
			behaviours[i].Update();
		}
	}

}
