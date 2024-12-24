
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class floweropen : UdonSharpBehaviour
{
public Animator mainFlowerAnimator;  // 主花的 Animator，必须是 public，用于从 Inspector 绑定
private Animator flowerAnimator;      // 当前花的 Animator，不需要是 public，直接获取

    void Start()
    {
        // 获取 Animator 组件
        flowerAnimator = GetComponent<Animator>();    }

    void Update()
    {
         if (mainFlowerAnimator.GetCurrentAnimatorStateInfo(0).IsName("open"))
        {
            // 主花的动画触发了，立即触发其他花的动画
            flowerAnimator.SetTrigger("PlayAnimation");
        }
    }
}
