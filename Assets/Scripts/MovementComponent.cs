using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float MovementSpeed = 100.0f;

    private Vector3 movementInput;
    private Weapon weaponComponent;

    private void Awake()
    {
        weaponComponent = GetComponent<Weapon>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movementInput.x = horizontalInput * MovementSpeed * Time.deltaTime;
        movementInput.z = verticalInput * MovementSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weaponComponent.Fire();
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(movementInput);
    }
}
