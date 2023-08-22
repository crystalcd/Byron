using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    public float radius = 2.0f;
    public float rotationSpeed = 30.0f; // 子弹围绕玩家的旋转速度（角度/秒）
    public Transform player;         // 玩家的Transform
    private float angle = 0.0f;      // 当前角度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateAroundPlayer();
    }

    void RotateAroundPlayer()
    {
        angle += rotationSpeed * Time.deltaTime;

        float x = Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
        float y = Mathf.Sin(angle * Mathf.Deg2Rad) * radius;

        Vector3 newPosition = player.position + new Vector3(x, y, 0);

        transform.position = newPosition;
    }
}
