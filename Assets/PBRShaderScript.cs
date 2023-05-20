using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBRShaderScript : MonoBehaviour
{
    public Renderer RD; //�������� �޽�������(��ũ��Ʈ�� �� ���� �޽�)
    //public Material MT; �������� ���͸���
    public Texture2D T2D; //�ؽ��� 2D��
    public Texture2DArray T2DArray; //�ؽ��� 2D�ε� �迭()
    public Texture3D T3D; //�Ⱦ�
    public Cubemap cubemap; //create - Legacy - Cubemap

    void Start()
    {
        RD.material.SetFloat("_Vector1", 0.5f); // �������� ����(���͸��� ���� X)
        //MT.SetFloat("_Vector", 1); ���͸��� �Ӽ� ��ü ����
        RD.material.SetInt("_Vector1", 0);
        RD.material.SetVector("_Vecto2", new Vector2(0,1));
        RD.material.SetVector("_Vectoc3", new Vector3(0, 1, 2));
        RD.material.SetVector("_Vector4", new Vector4(0, 1, 2, 3));
        RD.material.SetColor("_Color", new Color(1, 1, 1, 1)); //0~1 �Ǽ���(0~255)
        RD.material.SetTexture("_Texture2D", T2D);
        RD.material.SetTexture("_Texture2DArray", T2DArray);
        RD.material.SetTexture("_Texture3D", T3D);
        RD.material.SetTexture("_Cubemap", cubemap);
        RD.material.SetInt("_Boolean", 1); //0 False/ 1 True
    }
}
