using UnityEngine;

public class obstacle3 : MonoBehaviour
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
        if(SquareThingy.time==1950){
            rigidBody.AddForce(new Vector3(9,2,0), ForceMode.Impulse);
        }

        
    }
}
