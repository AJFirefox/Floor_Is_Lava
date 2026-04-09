using UnityEngine;
public class BumpSound : MonoBehaviour
{
    [SerializeField] AudioClip bump;
    [SerializeField] AudioClip crash;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collision) //Plays Sound Whenever collision detected
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            audio.PlayOneShot(bump);
        }
        if (collision.gameObject.tag == "Domino")
        {
            audio.PlayOneShot(crash);
        }
        if (collision.gameObject.tag == "ramp")
        {
            audio.PlayOneShot(bump);
        }
    }
}

