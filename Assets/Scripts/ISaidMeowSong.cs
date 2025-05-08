using UnityEngine;

public class ISaidMeowSong : MonoBehaviour
{
    public static AudioSource isaidmeow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isaidmeow = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
    if(SquareThingy.time == 1){
        isaidmeow.Stop();
    }
    if(SquareThingy.time == 250){
        isaidmeow.Play();
    }
    }

    public static void playISaidMeow(){
        if(InputHandler.songSelector == "ISaidMeow"){


        }

    }

}
