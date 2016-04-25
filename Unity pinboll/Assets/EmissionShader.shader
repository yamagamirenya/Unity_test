Shader "Custom/EmissionShader" {
	Properties {
		//innspecterzyoudeugokasuyatu
		_EmissionColor("Emission Color",Color)= (1.0,1.0,1.0,1.0)
		_MainTex("Base(RGB)",2D)="white"{}
	//setteisitatexturenitaiousitakudrasu
	    _EmissionTex("Emission Texture",2D)="white"{}
		//
	}
		SubShader{
		//subetenopasunikyoutuunozyoutaiwosetteisuru
		//renderingPassmnoteighiwosuru
			Tags { "RenderType" = "Opaque" }
			LOD 200

			CGPROGRAM
		
		#pragma surface surf Lambert
		//surfaceShardersiyousuruyonomeirei

		half4 _EmissionColor;
	sampler2D _MainTex;
	sampler2D _EmissionTex;
		// Use shader model 3.0 target, to get nicer looking lighting

		struct Input {
			float2 uv_MainTex;
		};


		void surf (Input IN, inout SurfaceOutput o) {
			half4 c = tex2D(_MainTex, IN.uv_MainTex);
			float t = ((2 * _SinTime.w*_CosTime.w) + 1.0)*0.5;
			float e = tex2D(_EmissionTex, IN.uv_MainTex).a*t;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
			o.Emission = _EmissionColor*e;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
