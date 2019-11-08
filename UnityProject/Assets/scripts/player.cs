using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("速度")],Rage(0f,100f)]
   public float speed = 3.5f;
    [Header("跳躍")],Rage(100,2000)]
    public int jump = 300;
    [Header("是否在地板上")],Tooltip("用來判斷角色是否在地板上")];
     public bool isGround  = false;
    [Header("角色名稱")]
    public string  name  = "Long";
}
