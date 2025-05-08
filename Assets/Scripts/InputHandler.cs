using UnityEngine;
using UnityEngine.InputSystem;
public class InputHandler : MonoBehaviour
{
    private Camera mainCamera;
    public static string songSelector = "7";
    private void Awake()
    {
        mainCamera = Camera.main;
    }
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

       string lastButtonPressed = rayHit.collider.gameObject.name;
       songSelector = "randomvalueiassigned";

        if(!(lastButtonPressed == "startButtonSelected"||lastButtonPressed == "ShieldButton"))//if song selected
        {
            songSelector = lastButtonPressed;
            Debug.Log(songSelector);
            if(songSelector=="ISaidMeow"){//i said meow
                ISaidMeowSong.isaidmeow.Play();
                MirageVIPSong.miragevip.Stop();
            }
            else if(songSelector=="MirageVIP"){//mirage vip
                MirageVIPSong.miragevip.Play();
                ISaidMeowSong.isaidmeow.Stop();
            }
        }

        if(lastButtonPressed == "StartButtonSelected")//supposed to start
        {
            start();
            if(songSelector=="ISaidMeow"){
                ISaidMeowSong.playISaidMeow();
            }
        }

        Debug.Log(rayHit.collider.gameObject.name);
    }
    public void start(){
        MainMenu.onMenu = false;
    }
}
