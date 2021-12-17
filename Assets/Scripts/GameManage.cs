using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public int number = 0;

    public void ChangeScene() {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "Main")
        {
            SceneManager.LoadScene("Exercise");
        }
        else
        {
            SceneManager.LoadScene("Main");
        }
    }
}
