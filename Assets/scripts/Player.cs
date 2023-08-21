using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("xxxx");
    }

    // Update is called once per frame
    void Update()
    {
        // 获取水平和垂直输入
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 计算移动方向
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0).normalized;

        // 更新角色位置
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // 如果需要，你还可以在这里添加动画相关的代码

    }
}
