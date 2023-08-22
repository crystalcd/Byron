using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public float speed = 10.0f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            // 计算朝向目标的方向
            Vector2 directionToTarget = (target.position - transform.position).normalized;

            // 更新方块位置 使其追踪目标
            transform.position += (Vector3)directionToTarget * speed * Time.deltaTime;
        } else
        {
            // 如果目标为空 销毁方块
            Destroy(gameObject);
        }
    }
}
