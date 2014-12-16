#pragma once

class Timer
{
public:
	bool Initialize();
	void Frame();

	float GetFrameTime();
	double GetTime();

private:
	INT64 m_frequency;
	float m_ticksPerMs;
	INT64 m_startTime;
	float m_frameTime;
};