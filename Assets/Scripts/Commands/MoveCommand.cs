using UnityEngine;

public class MoveCommand : Command
{
    private Vector3 direction;

    public MoveCommand(GameObject inputObject, Vector3 directionInput) : base(inputObject)
    {
        direction = directionInput;
    }
    
    public override void Execute()
    {
        gameObject.transform.Translate(direction);
    }

    public override void Undo()
    {
        direction *= -1;
        gameObject.transform.Translate(direction);
    }
}
