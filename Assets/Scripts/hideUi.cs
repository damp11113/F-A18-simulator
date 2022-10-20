using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideUi : MonoBehaviour
{
    public Canvas UI;
    private int intelligence = 2;

    // Start is called before the first frame update
    void Start()
    {
        hideuii();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Hideui")) {
            if (intelligence == 1) {
                intelligence += 2;
            }
            intelligence -= 1;
            hideuii();
        }
    }

    void hideuii() {
        switch (intelligence) {
            case 2:
                UI.enabled = true;
                break;
            case 1:
                UI.enabled = false;
                break;
            default:
                print ("Incorrect intelligence level.");
                break;
        }
    }
}
