using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 0.6f;
    private Rigidbody2D rb;

    //two methods of jump i have the arrow key and the space bar method ivan on tech is the arropw key method and the one in use
    private float jumpInput;

    [SerializeField]
    private float jumpForce;
    private float jumpsDone;
    private float prevJumpInu;

    private TextManger textManger;


    //[SerializeField]
    private float moveInput;

    [SerializeField]
    private float jumpsAllowed;

    private bool isJumping;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        jumpsDone = 0;
        jumpsAllowed = 3;
        prevJumpInu = 0;
        
    }

    // Update is called once per frame

    private void FixedUpdate() //fixed update is called at each physcis step can be called 0 times or multiple time - its called all the time its essentially what give this game motion
    {
        //-1 left, 0 is still, 1 is right
        moveInput = Input.GetAxis("Horizontal");
        //easy way to get movment in there

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        jumpInput = Input.GetAxis("Vertical");

    

             if (jumpInput > 0 && jumpsAllowed > jumpsDone && prevJumpInu == 0)
             {

               
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                    Debug.Log("jump");
                    isJumping = true;
                    jumpsDone ++;
               
                 



                
                //else
                //{
                    //isJumping = false;
                //}



             }

             prevJumpInu = jumpInput; //we set the previous input to the current input now when run this method we will have updated the prev input to a current position there in


       
    
        
        



        //if (Input.GetButtonDown("Jump"))
        //{
           // Jump();
        //}
      
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            jumpsDone = 0;
        }
        else if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            TextManger.textManager.IncreaseScore();
        }

        Debug.Log(collision.gameObject.tag);
    }

    //private void Jump()
    //{
    //rb.AddForce(Vector3.up * jumpForce);
    //}

    private void SpeedSetter()
    {
        //moveInput = moveInput * speed;
    }

   

    void Update()//uiipdate is called blindley at 60 seconds per frame
    {
        //if (Input.GetButtonDown("Jump"))
        //{
            //Jump();
        //}
    }
}
