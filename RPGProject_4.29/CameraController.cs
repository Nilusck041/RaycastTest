using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    #region  #####��ͷ���ñ���   
    public Vector3 offset;
    public float zoomSpeed = 4f;/*������ű���*/
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f;

    public float yawSpeed = 100f;/*�����ת����*/

    private float currentZoom = 10f;
    private float currentYaw = 0f;
    #endregion

    private void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        currentYaw -=  Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        /*�������*/
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);//target����ҵײ�����Ҹ�2f������ʱ�������߶ȵ�λ

        /*�����ת*/
        transform.RotateAround(target.position, Vector3.up, currentYaw);
    }
}
