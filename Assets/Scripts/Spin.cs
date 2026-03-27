using UnityEngine;

public class Spin : MonoBehaviour
{
        public float spinSpeed;
        public Vector3 axis;
    

    
    private void Update()
    {
        transform.Rotate(axis * spinSpeed *  Time.deltaTime);
    }
}
