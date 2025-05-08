using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public static AudioSource isaidmeow;
    public static AudioSource miragevip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isaidmeow = GetComponent<AudioSource>();
        miragevip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
