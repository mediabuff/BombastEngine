#include "Timer.h"

bool Timer::Initialize()
{
	BOOL result;

	result = QueryPerformanceFrequency(&m_frequency);
	if (!result)
	{
		return false;
	}

	m_ticksPerMs = double(m_frequency.QuadPart) / 1000.0;

	QueryPerformanceCounter(&m_counter);
	m_counterStart = m_counter.QuadPart;

	return true;
}

void Timer::Frame()
{
	float frameDifference;

	QueryPerformanceCounter(&m_counter);

	double newElapsedTime = (double(m_counter.QuadPart) - m_counterStart) / m_ticksPerMs;


	frameDifference = (float)(newElapsedTime - m_currentTime);
	m_frameTime = frameDifference;
	
	m_currentTime = newElapsedTime;

	return;
}