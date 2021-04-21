using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public Transform objectToPlace;
    public Camera gameCamera;

    // Update is called once per frame
    void Update()
    {
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition); //camera��һ���ǳ��а����ĺ�����������ʵʱλ��
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo))
        {
            objectToPlace.position = hitInfo.point;
            objectToPlace.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);//hitInfo.normal���Լ���cube��rotation
                                                                            //�ô���Ŀ������cube���ƶ������У����ŵ���������仯��ת�Ƕ�
        }
    }
}
