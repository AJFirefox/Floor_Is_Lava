using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class ButtonTrigger : MonoBehaviour
{
    public VideoPlayer myVideoPlayer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Optional: check for specific tag
        {
            myVideoPlayer.Play();
        }
    }
}