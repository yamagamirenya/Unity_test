Shader "Custom/test Texture" {
	SubShader{
		Pass{
		CGPROGRAM

	#pragma vertex vert
	#pragma fragment frag
	#pragma target 3.0

		struct appdata_base {
		float4 vertex : POSITION;
		float3 normal : NORMAL;
		float4 texcood: TEXCOORD0;
		};

	float4 vert(appdata_base v) :POSITION{
		return mul(UNITY_MATRIX_MVP,v.vertex);
	}

	fixed4 frag(float4 sp : WPOS) : COLOR{
		fixed2 red_green = sp.xy / _ScreenParams.xy;
	fixed blue = 0.0;
	fixed alpha = 0.5f;
	return fixed4(red_green, blue, alpha);
	}
	ENDCG
		}
	}
}