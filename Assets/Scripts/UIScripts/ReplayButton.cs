using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour
{
 public void ReplayLevel()
    {
        SceneManager.LoadScene("LevelDesignScene");
    }
}
