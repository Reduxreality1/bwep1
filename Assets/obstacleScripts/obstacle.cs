using UnityEngine;

public class obstacle : MonoBehaviour
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
        if(SquareThingy.time==250){
            rigidBody.AddForce(new Vector3(-10,3,0), ForceMode.Impulse);
        }
    }
}
