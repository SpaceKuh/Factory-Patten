using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    protected CommandManager commandManager;
    public void Register()
    {
        commandManager = CommandManager.GetInstance();
        commandManager.Subscribe(this);
    }
    public virtual void Execute() { 
        
    }
    public virtual void Undo() { }

}