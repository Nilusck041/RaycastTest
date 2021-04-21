using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public LayerMask mask;

    private void Start()
    {
        Physics2D.queriesStartInColliders = false;//2D��3Dһ����ͬ�����ڣ�3D���������ʱ��ֱ�Ӵ���Դ�����box collider
                                                 //��2D���ᴩ������͵������ߴ�Դ�����ڲ����������Դbox collider��ס
                                                 //������������������Ҫ����Ϊfalse
    }

    // Update is called once per frame
    void Update()
    {
       RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right,100,mask,0f,1f);
        if(hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red, 100);
        }else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * 100, Color.green);
        }
    }
}
