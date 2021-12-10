using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 100.0f;
    
    private Weapon weaponComponent;
    private CommandProcessor commandProcessor;
    private Vector3 movementInput;
    private bool undoing = false;

    private void Awake()
    {
        weaponComponent = GetComponent<Weapon>();
        commandProcessor = GetComponent<CommandProcessor>();
    }

    void Update()
    {
        movementInput.x =  Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        movementInput.z = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weaponComponent.Fire();
        }

        undoing = Input.GetKey(KeyCode.F);
    }

    private void FixedUpdate()
    {
        if (undoing)
        {
            commandProcessor.Undo();
            return;
        }
        if (movementInput != Vector3.zero)
        {
            MoveCommand moveCommand = new MoveCommand(gameObject, movementInput);
            commandProcessor.ExecuteCommand(moveCommand);
        }
    }
}
