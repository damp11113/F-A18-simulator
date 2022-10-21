using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideUi : MonoBehaviour
{
    public GameObject Panel, Panel2, Panel3, Panel4, Panel5;
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
                Panel.SetActive(true);
                Panel2.SetActive(true);
                Panel3.SetActive(true);
                Panel4.SetActive(true);
                Panel5.SetActive(true);
                break;
            case 1:
                Panel.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                break;
            default:
                print ("Incorrect intelligence level.");
                break;
        }
    }
}
