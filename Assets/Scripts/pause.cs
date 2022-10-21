using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject Panel;
    private int intelligence = 2;

    // Start is called before the first frame update
    void Start()
    {
        pausee();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("pausee")) {
            if (intelligence == 1) {
                intelligence += 2;
            }
            intelligence -= 1;
            pausee();
        }
    }

    void pausee() {
        switch (intelligence) {
            case 2:
                Panel.SetActive(false);
                Time.timeScale = 1;
                break;
            case 1:
                Panel.SetActive(true);
                Time.timeScale = 0;
                break;
            default:
                print ("Incorrect intelligence level.");
                break;
        }
    }
    public void resetGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void back2MainMenu() {
        Application.LoadLevel("Menu");
    }

}
