#pragma once

#include "Geometry.h"
#include "SceneNode.h"
#include "../Events/EventManager.h"
#include "Lighting.h"

typedef std::map<ActorId, ISceneNode*> SceneActorMap;

class CameraNode;
class SkyNode;
class LightNode;

class Scene
{
public:
	Scene(IRenderer* renderer);
	virtual ~Scene();

	HRESULT DoRender();
	HRESULT OnRestore();
	HRESULT OnLostDevice();
	HRESULT OnUpdate(const float deltaMs);
	ISceneNode* FindActor(ActorId id);
	bool AddChild(ActorId id, ISceneNode* kid);
	bool RemoveChild(ActorId id);

	void NewRenderComponentDelegate(EventDataPtr pEventData);

	void SetCamera(CameraNode* camera) { m_pCamera = camera; }
	CameraNode * const GetCamera() const { return m_pCamera; }

	const Mat4x4 GetTopMatrix()
	{
		return static_cast<const Mat4x4>(*m_pMatrixStack->Top());
	}
	
	void PushAndSetMatrix(const Mat4x4 &toWorld) {
		m_pMatrixStack->Push();
		m_pMatrixStack->MultMatrixLocal(&toWorld);
		Mat4x4 mat = GetTopMatrix();
		m_pRenderer->VSetWorldTransform(&mat);
	}

	void PopMatrix()
	{
		m_pMatrixStack->Pop();
		Mat4x4 mat = GetTopMatrix();
		m_pRenderer->VSetWorldTransform(&mat);
	}

	IRenderer* GetRenderer() const { return m_pRenderer; }

	LightingManager* GetLightingManager() const { return m_pLightManager; }


	HRESULT Pick(RayCast *pRayCast) { return m_pRoot->VPick(this, pRayCast); }

protected:
	HRESULT OnForwardRender();
	HRESULT OnDeferredRender();

protected:
	SceneNode* m_pRoot;
	CameraNode* m_pCamera;
	IRenderer* m_pRenderer;

	BMMatrixStack* m_pMatrixStack;
	SceneActorMap m_actorMap;

	LightingManager* m_pLightManager;

	void RenderAlphaPass();
};