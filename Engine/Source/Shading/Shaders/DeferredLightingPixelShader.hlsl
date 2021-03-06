//Take in 2 Render Targets Textures with Color and Normal Information
Texture2D colorTexture : register(t0);
Texture2D normalTexture : register(t1);
Texture2D depthTexture : register(t2);

//Sampler for the exact per-pixel data values from render textures
SamplerState PointSampler : register(s0);

cbuffer LightBuffer : register(b0)
{
	matrix inverseViewProjection;
	float4 lightDirection;
};

cbuffer CameraBuffer : register(b1)
{
	float3 camPos;
	float padding;
};

struct V2P
{
	float4 position: SV_POSITION;
	float2 uv: TEXCOORD0;
	float3 viewDirection : TEXCOORD1;
};

float4 CalcSpecular(float3 viewDir, float3 lightDir, float intensity, float3 normal, float specPower)
{
	float4 result = float4(0, 0, 0, 0);
	
	if (intensity > 0.0f) {
		float3 reflection = normalize(2 * intensity * normal - lightDir);
		float posDot = saturate(dot(reflection, viewDir));
		result = pow(posDot, specPower);
	}

	return result;
};

float4 DeferredLightingPS(V2P input) : SV_TARGET
{
	float4 colors;
	float4 normals;
	float3 lightDir;
	float lightIntensity;
	float4 outColor;

	//Sample Color from diffuse Render Texture
	colors = colorTexture.Sample(PointSampler, input.uv);
	//Sample normal from normals Render Texture
	normals = normalTexture.Sample(PointSampler, input.uv);

	lightDir = -lightDirection;

	lightIntensity = saturate(dot(normals.xyz, lightDir));

	uint3 index = uint3(input.position.x, input.position.y, 0);
	float depth = depthTexture.Load(index).r;

	float3 posWS = camPos + input.viewDirection * depth;

	//pow(0,0) not valid, so make sure power never 0
	normals.w = max(normals.w, 0.1);

	float3 reflection = normalize(2 * lightIntensity * normals.xyz - lightDir);
	float4 specular = pow(saturate(dot(reflection, input.viewDirection)), normals.w);

	outColor = saturate((colors * lightIntensity));

	return outColor;
}