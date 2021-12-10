using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 100.0f;
    
    private Weapon weaponComponent;
    private CommandProcessor commandProcessor;
    private Vector3 movementInput;
    private bool undoing;

    private void Awake()
    {
        weaponComponent = GetComponent<Weapon>();
        commandProcessor = GetComponent<CommandProcessor>();
    }

    void Update()
    {
        GatherMovementInput();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weaponComponent.Fire();
        }

        undoing = Input.GetKey(KeyCode.F);
    }

    private void GatherMovementInput()
    {
        movementInput.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        movementInput.z = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (undoing)
        {
            commandProcessor.Undo();
        }
        else if (movementInput != Vector3.zero)
        {
            MoveCommand moveCommand = new MoveCommand(gameObject, movementInput);
            commandProcessor.ExecuteCommand(moveCommand);
        }
    }
}
