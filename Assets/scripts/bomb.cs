using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector3 shootDir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 子弹向前移动
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
