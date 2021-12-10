using UnityEngine;

public abstract class Command
{
    protected GameObject gameObject;
    
    public Command(GameObject inputObject)
    {
        gameObject = inputObject;
    }

    public abstract void Execute();
    public abstract void Undo();
}
