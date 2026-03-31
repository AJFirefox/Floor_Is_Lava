using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using System.Collections;

public class OffsetChange : MonoBehaviour
{

    public Material Animated; 

    public float offsetX;
    public float offsetY;

    public Vector2 newOffset;

    public float minSpeed = 2f;
    public float maxSpeed = 10f;
    public float changeInterval = 1f;
    [Range(-5f, 5f)]
    public float speed = 1f;
    [Range(-5f, 5f)]
    public float speedX = 1f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(ChangeSpeedRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        newOffset.x += speedX * Time.deltaTime;
        newOffset.y += speed * Time.deltaTime;

        if (newOffset.x > 1f)
        {
            newOffset.x -= 1f;
        }
        if (newOffset.x < -1f)
        {
            newOffset.x += 1f;
        }

        if (newOffset.y > 1f)
        {
            newOffset.y -= 1f;
        }
        if (newOffset.y < -1f)
        {
            newOffset.y += 1f;
        }
            Animated.mainTextureOffset = new Vector2(newOffset.x, newOffset.y);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    IEnumerator ChangeSpeedRoutine()
    {
        while (true)
        {
            speed = Random.Range(minSpeed, maxSpeed);
            speedX = Random.Range(minSpeed, maxSpeed);

            yield return new WaitForSeconds(changeInterval); // Wait before changing again
        }
    }
}
