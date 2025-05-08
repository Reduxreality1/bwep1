using UnityEngine;

public class obstacle7 : MonoBehaviour
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
                        rigidBody.AddForce(new Vector3(0,9,0), ForceMode.Impulse);
                     }
    }
}
