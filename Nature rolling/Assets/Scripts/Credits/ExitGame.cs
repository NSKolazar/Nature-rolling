using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public AudioSource effect;
    public void Quit()
    {
        effect.Play();
        Application.Quit();
    }
}
