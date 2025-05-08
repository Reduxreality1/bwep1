using UnityEngine;

public class NoSong : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if((!MainMenu.onMenu)&&InputHandler.songSelector=="7"){
            rb.AddForce(new Vector3(-1,0,0), ForceMode.Impulse);

        }
    }
}
