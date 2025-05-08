using UnityEngine;

public class obstacle5 : MonoBehaviour
{

    public Rigidbody rigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(SquareThingy.time==3800){
           rigidBody.AddForce(new Vector3(-9,0,0), ForceMode.Impulse);
        }
    }
}
