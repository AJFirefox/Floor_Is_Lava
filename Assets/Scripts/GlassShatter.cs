using UnityEngine;

public class GlassShatter : MonoBehaviour
{
    public GameObject wholeGlass;
    public Rigidbody[] shards;

    public float explosionForce = 1f;
    public float explosionRadius = 2f;
    public float YForce = 0.4f;

    private bool hasShattered = false;

    public AudioSource glassBreakAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(Rigidbody r in shards)
        {
            r.gameObject.SetActive(false);
            r.isKinematic = true;
        }

        wholeGlass.SetActive(true);
    }

    // Update is called once per frame
  /*  void Update()
    {
        if (hasShattered) return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.gameObject == wholeGlass)
                {
                    Shatter(hit.point);
                }

            }

        }
          
    }

   */ void Shatter( Vector3 hitPoint)
    {
        hasShattered |= true;

        wholeGlass.SetActive(false);

        foreach (Rigidbody r in shards)
        {
            r.gameObject.SetActive(true);
            r.isKinematic = false;
            r.AddExplosionForce(explosionForce, hitPoint, explosionRadius, YForce);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Shatter(collision.contacts[0].point);
        }

        if (glassBreakAudio != null)
            glassBreakAudio.Play();
    }

}
