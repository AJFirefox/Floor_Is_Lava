using UnityEngine;

public class RainbowColor : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float hue = Mathf.PingPong(Time.time * 0.2f, 1);
        rend.material.color = Color.HSVToRGB(hue, 1, 1);
    }
}