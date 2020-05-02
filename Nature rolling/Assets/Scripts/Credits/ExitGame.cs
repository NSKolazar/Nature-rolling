using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    [SerializeField] AudioSource effect;
    public void Quit()
    {
        effect.Play();
        Application.Quit();
    }
}
