using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager
{
    private static CommandManager instance;
    private List<Command> commands;
    private CommandManager()
    {
        commands = new List<Command>();
    }


    public static CommandManager GetInstance()
    {
        if (instance == null)
            instance = new CommandManager();

        return instance;
    }

    public void Subscribe(Command _command)
    {
        commands.Add(_command);
    }

    public void UndoLastCommand()
    {
        if (commands.Count == 0)
            return;
        Command lastCommand = commands[commands.Count - 1];
        lastCommand.Undo();
        commands.Remove(lastCommand);
    }
}