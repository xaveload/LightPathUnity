using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Monster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.eulerAngles);
    }
}
