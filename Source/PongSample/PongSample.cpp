#include "Msvc\PongSampleStd.h"
#include "../Bombast/CoreGameLogic.h"
#include "../Bombast/BombastApp.h"

#include "Msvc\PongSample.h"

PongSampleApp g_PongSampleApp;

INT WINAPI wWinMain(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPWSTR    lpCmdLine,
	int       nCmdShow)
{
	return BombastEngine(hInstance, hPrevInstance, lpCmdLine, nCmdShow);
}

CoreGameLogic *PongSampleApp::VCreateGameAndView()
{
	g_pApp->m_options.m_level = "World\\World.xml";
	
	m_pGame = BE_NEW PongSampleLogic();
	m_pGame->Initialize();

	return m_pGame;
}

PongSampleLogic::PongSampleLogic()
{
}

PongSampleLogic::~PongSampleLogic()
{
}

void PongSampleLogic::VChangeState(CoreGameState newState)
{
	CoreGameLogic::VChangeState(newState);

	switch (newState)
	{
		case CGS_SpawningPlayersActors:
		{
			Actor* pActor = VCreateActor("Actors\\paddle.xml", NULL);

			break;
		}
	}
}

bool PongSampleLogic::VLoadGameDelegate(rapidxml::xml_node<>* pLevelData)
{
	return true;
}

void PongSampleLogic::VMoveActor(const ActorId id, Mat4x4 const &mat)
{
	//CoreGameLogic::VMoveActor(id, mat);
}