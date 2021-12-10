using System.Collections.Generic;
using UnityEngine;

public class CommandProcessor : MonoBehaviour
{
    private List<Command> commands = new List<Command>();
    private int currentIndex;

    public void ExecuteCommand(Command command)
    {
        commands.Add(command);
        command.Execute();
        currentIndex = commands.Count - 1;
    }

    public void Undo()
    {
        if (currentIndex < 0)
        {
            return;
        }
        
        commands[currentIndex].Undo();
        commands.RemoveAt(currentIndex);
        currentIndex--;
    }
}
