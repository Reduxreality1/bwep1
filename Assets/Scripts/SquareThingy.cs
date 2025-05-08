using UnityEngine;

public class SquareThingy : MonoBehaviour
{
    public float moveSpeed;
    bool dead = false;
    float speedX, speedY;
    public Rigidbody2D rb; //rigidbody
    public static int time = 0;//frames since the game starts
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //dead = Physics.CheckSphere(DeadCheck.transform.position, .2f, LayerMask.GetMask("obstacle"));
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);
    if(!MainMenu.onMenu)
        {
            time++;
            Debug.Log(time);
        }

        //Debug.Log(time);
    }


}
