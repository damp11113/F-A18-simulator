using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCam : MonoBehaviour
{
    public Camera Camera, Camera2, Camera3, Camera4, Camera5, Camera6, Camera7;

    private int intelligence = 7;
    // Start is called before the first frame update
    void Start()
    {
        switchcam();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cam")) {
            if (intelligence == 1) {
                intelligence += 7;
            }
            intelligence -= 1;
            switchcam();
        }
    }

    void switchcam()
    {
        switch (intelligence)
        {
        case 7:
            Camera.enabled = true;
            Camera2.enabled = false;
            Camera3.enabled = false;
            Camera4.enabled = false;
            Camera5.enabled = false;
            Camera6.enabled = false;
            Camera7.enabled = false;
            break;
        case 6:
            Camera.enabled = false;
            Camera2.enabled = true;
            Camera3.enabled = false;
            Camera4.enabled = false;
            Camera5.enabled = false;
            Camera6.enabled = false;
            Camera7.enabled = false;
            break;
        case 5:
            Camera.enabled = false;
            Camera2.enabled = false;
            Camera3.enabled = true;
            Camera4.enabled = false;
            Camera5.enabled = false;
            Camera6.enabled = false;
            Camera7.enabled = false;
            break;
        case 4:
            Camera.enabled = false;
            Camera2.enabled = false;
            Camera3.enabled = false;
            Camera4.enabled = true;
            Camera5.enabled = false;
            Camera6.enabled = false;
            Camera7.enabled = false;
            break;
        case 3:
            Camera.enabled = false;
            Camera2.enabled = false;
            Camera3.enabled = false;
            Camera4.enabled = false;
            Camera5.enabled = true;
            Camera6.enabled = false;
            Camera7.enabled = false;
            break;
        case 2:
            Camera.enabled = false;
            Camera2.enabled = false;
            Camera3.enabled = false;
            Camera4.enabled = false;
            Camera5.enabled = false;
            Camera6.enabled = true;
            Camera7.enabled = false;
            break;
        case 1:
            Camera.enabled = false;
            Camera2.enabled = false;
            Camera3.enabled = false;
            Camera4.enabled = false;
            Camera5.enabled = false;
            Camera6.enabled = false;
            Camera7.enabled = true;
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }
}
