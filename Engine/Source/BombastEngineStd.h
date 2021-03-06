#pragma once

#define WIN32_LEAN_AND_MEAN //Exclude Rarely used stuff from Windows Headers
#define __D3D11 (1);

#define USE_PHYSX

#if defined(_DEBUG)
	//#define DEBUG_D3D
#endif

#include <Windows.h>
#include<windowsx.h>

#include <tchar.h>
#include <direct.h>

#include <crtdbg.h>

#include <dxgi.h>
#include <d3dcommon.h>
#include <d3d11.h>
#include <DirectXMath.h>

#include <string>
#include <memory>

const int MAX_LIGHTS_SUPPORTED = 4;
const int BOMBAST_MAX_PATH = 256;

const int SCREEN_WIDTH = 640;
const int SCREEN_HEIGHT = 480;
const int SCREEN_X = 0;
const int SCREEN_Y = 0;

extern std::string ROOT_ENGINE_PATH;
extern std::string ROOT_GAME_PATH;

#include "Debugging\Logger.h"
#include "Utilities\types.h"
#include "Utilities\Math.h"
#include "Graphics3D\Geometry.h"
#include "Utilities\FastDelegate\FastDelegate.h"

#if defined(_DEBUG)
	#define BE_NEW new(_NORMAL_BLOCK,__FILE__, __LINE__)
#else
	#define BE_NEW new
#endif

#if !defined(SAFE_DELETE)
	#define SAFE_DELETE(x) if(x) delete x; x=NULL;
#endif

#if !defined(SAFE_DELETE_ARRAY)
	#define SAFE_DELETE_ARRAY(x) if(x) delete [] x; x=NULL;
#endif

#if !defined(SAFE_RELEASE)
	#define SAFE_RELEASE(x) if(x) x->Release(); x=NULL;
#endif

class BE_NonCopyable
{
private:
	BE_NonCopyable(const BE_NonCopyable& x);
	BE_NonCopyable&	operator=(const BE_NonCopyable& x);
public:
	BE_NonCopyable() {};
};

extern Vec4 g_White;
extern Vec4 g_Black;

extern const float fOPAQUE;
extern const int iOPAQUE;
extern const float fTRANSPARENT;
extern const int iTRANSPARENT;

extern INT WINAPI BombastEngine(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	HWND hWnd = NULL,
	LPWSTR lpCmdLine = NULL);

struct AppMsg
{
	HWND m_hWnd;
	UINT m_uMsg;
	WPARAM m_wParam;
	LPARAM m_lParam;
};