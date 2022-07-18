using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detect_Fall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}
