using UnityEngine;

public class ScreenController : MonoBehaviour
{  
    void Awake()
    {  
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.fullScreen = true;
    }  
}
