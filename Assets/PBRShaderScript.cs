using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBRShaderScript : MonoBehaviour
{
    public Renderer RD; //참조중인 메쉬렌더러(스크립트가 들어간 옵젝 메쉬)
    //public Material MT; 참조중인 메터리얼
    public Texture2D T2D; //텍스쳐 2D임
    public Texture2DArray T2DArray; //텍스쳐 2D인데 배열()
    public Texture3D T3D; //안씀
    public Cubemap cubemap; //create - Legacy - Cubemap

    void Start()
    {
        RD.material.SetFloat("_Vector1", 0.5f); // 렌더러만 변경(메터리얼 영향 X)
        //MT.SetFloat("_Vector", 1); 메터리얼 속성 자체 변경
        RD.material.SetInt("_Vector1", 0);
        RD.material.SetVector("_Vecto2", new Vector2(0,1));
        RD.material.SetVector("_Vectoc3", new Vector3(0, 1, 2));
        RD.material.SetVector("_Vector4", new Vector4(0, 1, 2, 3));
        RD.material.SetColor("_Color", new Color(1, 1, 1, 1)); //0~1 실수값(0~255)
        RD.material.SetTexture("_Texture2D", T2D);
        RD.material.SetTexture("_Texture2DArray", T2DArray);
        RD.material.SetTexture("_Texture3D", T3D);
        RD.material.SetTexture("_Cubemap", cubemap);
        RD.material.SetInt("_Boolean", 1); //0 False/ 1 True
    }
}
