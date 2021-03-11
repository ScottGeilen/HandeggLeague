using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySelector : MonoBehaviour
{
    public void Select(string playName) {
        SceneManager.LoadScene(1);
    }
}
