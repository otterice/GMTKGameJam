using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] private LayerMask dashLayerMask;
    private Vector3 moveDir;
    public float ms = 30f;
    public bool isDashButtonDown;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W)) {
            moveY = +1f;
        }
        if (Input.GetKey(KeyCode.A)) {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.S)) {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.D)) {
            moveX = 1f;
        }

        moveDir = new Vector3(moveX, moveY).normalized;

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            isDashButtonDown = true;
        }
    }

    private void FixedUpdate() {
        rb.velocity = moveDir * ms;

        if (isDashButtonDown) {
            float dashAmt = 2f;
            Vector3 dashPos = transform.position + moveDir * dashAmt;
            RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, moveDir, dashAmt, dashLayerMask);
            if (raycastHit2D.collider != null) {
                dashPos = raycastHit2D.point;
            }

            rb.MovePosition(dashPos);
            isDashButtonDown = false;
        }
    }
}
