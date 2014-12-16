#include "..\Bombast\BombastApp.h"

LRESULT CALLBACK WindowProc(HWND hWnd,
                         UINT message,
                         WPARAM wParam,
                         LPARAM lParam);

int WINAPI BombastEngine(HINSTANCE hInstance,
                   HINSTANCE hPrevInstance,
                   LPWSTR lpCmdLine,
                   int nCmdShow)
{
	//Setup Checks for memory leaks
	int tmpDbgFlag = _CrtSetDbgFlag(_CRTDBG_REPORT_FLAG);

	//Used at Program Init to force leak check before exit
	tmpDbgFlag |= _CRTDBG_LEAK_CHECK_DF;

	_CrtSetDbgFlag(tmpDbgFlag);

	g_pApp->m_options.Init((ROOT_GAME_PATH + "Options.xml").c_str(), lpCmdLine);

	if (g_pApp->InitInstance(hInstance, lpCmdLine, 0, g_pApp->m_options.m_screenSize.x, g_pApp->m_options.m_screenSize.y, g_pApp->m_options.m_screenPosition.x, g_pApp->m_options.m_screenPosition.y))
	{
		g_pApp->Run();
	}

	g_pApp->ShutDown();
	
	return 0;
}