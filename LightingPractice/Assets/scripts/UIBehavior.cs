using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehavior : MonoBehaviour
{

    public void LoadLightProbes()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLightingPractice()
    {
        SceneManager.LoadScene(0);
    }
}
