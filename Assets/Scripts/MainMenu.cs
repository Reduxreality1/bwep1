using UnityEngine;

public class MainMenu : MonoBehaviour
{

public Rigidbody rigidBody;
public static bool onMenu;
public static int menuSelector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onMenu = true;
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!onMenu){//i ain't know how this works
            rigidBody.AddForce(new Vector3(10000,10000,10000), ForceMode.Impulse);//gets the menu off the screen
            onMenu = false;
        }
    }
}
