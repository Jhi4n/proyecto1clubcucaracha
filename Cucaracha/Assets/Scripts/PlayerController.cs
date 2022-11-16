using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float JumpForce = 1.0f;

    private Vector3 moveDirection;

    public float gravityScale = 5f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    public Transform cam;
    public GameObject playerModel;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("multiplicador", 5);

        //LUIS CANARY
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        //LUIS CANARY



        moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;


        //LUIS CANARY
        if (direction.magnitude >= 0.1f)
        {

        }
        //

        //
        animator.SetFloat("speed", Mathf.Abs(direction.magnitude));
    }
}
