using UnityEngine;

public class RainbowGlow : MonoBehaviour
{
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float hue = Mathf.PingPong(Time.time * 0.3f, 1);
        Color rainbow = Color.HSVToRGB(hue, 1, 1);

        rend.material.color = rainbow;
        rend.material.SetColor("_EmissionColor", rainbow * 3f);
    }
}