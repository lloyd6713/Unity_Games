using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour

{

    public Rigidbody rb;
    public Transform Camera;

    private Vector3 PlayerMovementInput;
    private Vector2 PlayerMouseInput;

    [SerializeField] private float Speed = 5f;
    public float Sensitivity = 5f;
    [SerializeField] private LayerMask Floormask;
    [SerializeField] private float Jumpforce = 3f;
    [SerializeField] private Transform FeetTransform;
    public Text MoneyTXT;
    public int money = 0;
    private float xRot;
    




    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        MoneyTXT.text = "$" + money.ToString();
 
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        PlayerMouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;


        rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);

        xRot -= PlayerMouseInput.y * Sensitivity;

        transform.Rotate(0f, PlayerMouseInput.x * Sensitivity, 0f);

        Camera.localRotation = Quaternion.Euler(xRot, 0f, 0f);


        if (Input.GetKeyDown(KeyCode.Space)) {
            if (Physics.CheckSphere(FeetTransform.position, 0.2f, Floormask)) {
                rb.AddForce(Jumpforce * Vector3.up, ForceMode.Impulse);
            }
            }
        }
    }

