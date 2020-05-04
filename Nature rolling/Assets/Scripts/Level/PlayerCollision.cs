using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    
    public TextMeshProUGUI text;
    public GameObject gate;

    [Space]

    [Header("Audio")]
    public AudioSource point;
    public AudioSource complete;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Key"))
        {
            text.text = "Task complete!\nNow go through the opened path!";
            point.Play();
            gate.SetActive(false);
            
        }

        if (collisionInfo.collider.CompareTag("End"))
        {       
            text.text = "Level complete!";
            complete.Play();
            Invoke("EndGame",2f);           
        }
    }

    void EndGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
