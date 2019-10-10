using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    [SerializeField]
    private GameObject targetObj;

    public float OffSetHeight;
    public float RotateSpeed;

    private Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = targetObj.transform.position;
        targetPos = new Vector3(
            targetPos.x,
            targetPos.y + OffSetHeight,
            targetPos.z);
    }

    private float value = 0;
    // Update is called once per frame
    void Update()
    {
        value += RotateSpeed / 100;
        this.transform.LookAt(targetPos, Vector3.up);
        this.transform.position = new Vector3(Mathf.Sin(value), 0.5f, Mathf.Cos(value));
    }
}
