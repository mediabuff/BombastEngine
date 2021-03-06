#pragma once

class MovementController : public IMouseHandler, public IKeyboardHandler
{
public:
	MovementController(SceneNode* pObject, float initialYaw, float initialPitch, bool rotateWhenRButtonDown);
	void SetObject(SceneNode* pNewObject);

	void OnUpdate(const float deltaMs);

public:
	bool VOnMouseMove(const Point &pos, const int radius);
	bool VOnMouseDown(const Point &pos, const int radius, const std::string &buttonName);
	bool VOnMouseUp(const Point &pos, const int radius, const std::string &buttonName);

	bool VOnKeyDown(const BYTE c) { m_bKey[c] = true; return true; }
	bool VOnKeyUp(const BYTE c) { m_bKey[c] = false; return true; }

	const Mat4x4 *GetToWorld() { return &m_matToWorld; }
	const Mat4x4 *GetFromWorld() { return &m_matFromWorld; }

protected:
	Mat4x4  m_matFromWorld;
	Mat4x4	m_matToWorld;
	Mat4x4  m_matPosition;

	Point m_lastMousePos;
	bool m_bKey[256];

	float m_targetYaw;
	float m_targetPitch;
	float m_yaw;
	float m_pitch;

	float m_maxSpeed;
	float m_accelRate;
	float m_deccelRate;

	float m_forwardSpeed, m_backwardSpeed, m_leftSpeed, m_rightSpeed, m_upSpeed, m_downSpeed;

	float m_turnRate;

	bool m_bCameraTrackMouseOnRightHold;
	bool m_bCameraTrackMouse;

	SceneNode* m_pObject;
};