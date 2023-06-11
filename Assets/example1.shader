Shader "Custom/example1"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        //스니핏(snippet) : 설정, 전처리부분이며 셰이더 조명계산 설정,기타 세부적인 분기를 정해줌
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0
        //----------------------------
        sampler2D _MainTex;

        //엔진으로부터 받아와야할 데이터(struct Input)
        struct Input
        {
            float2 uv_MainTex;
        };
        //----------------------------
        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

        //함수 부분 프로퍼티스가 작동되게하는 곳
        void surf (Input IN, inout SurfaceOutputStandard o) //SurfaceOutputStandard라는 가방(구조체)안에 변수가 들어있다 , inout은 변수를 빼낼수도,넣을수도 있다는 선언문이다.(뒤에 o는 import math as m같은 긴이름대신 줄여부르겠다는 의미)
        {

            o.Albedo = float3(1,0,0);
            
        }
        ENDCG
    }
    FallBack "Diffuse"
}
