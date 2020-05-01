using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public TextMeshProUGUI text;
    public MeshCollider gateCollider;
    public MeshRenderer gateRender;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Key")
        {
            text.text = "Task complete!\nNow go through the opened path!";
            gateCollider.enabled = false;
            gateRender.enabled = false;
        }

        if (collisionInfo.collider.tag == "End") 
        {
            movement.enabled = false;
        }
    }

}
