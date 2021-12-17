Shader "Custom/Mask"
{
    Properties
    {
        
    }
    SubShader
    {
        Tags{"Queue" = "Geometry-1"}

        ColorMask 0

        ZWrite Off

        Stencil {
            Ref 1
            Comp Always
            Pass Replace
        }

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Lambert

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 worldPos;
        };


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            o.Albedo = fixed4(1,1,1,1);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
