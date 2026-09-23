using Unity.VisualScripting;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotateSpeed, 0f);
    }
}
