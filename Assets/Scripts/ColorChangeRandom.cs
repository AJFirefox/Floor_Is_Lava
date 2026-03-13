using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material[] colors;
    private MeshRenderer myRenderer;

    private void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Domino") || collision.gameObject.CompareTag("Player"))
        {
            int rand = Random.Range(0, colors.Length);
            myRenderer.material = colors[rand];
        }
    }

}
