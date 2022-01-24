using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;

    private void Update()
    {
        //Get MoveInput
        //Preferably get input in regular Update()
        var moveInput = Input.GetAxis("Horizontal");
        
        //Set move velocity
        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);
        
        //Apply jump force
        //Preferably get input in regular Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        if (jumpInput && myRigidbody.velocity.y <= 0.5f)
            myRigidbody.AddForce(Vector3.up * jumpForce);
            
        
    }
}
