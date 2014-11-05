#ifndef BOMBAST_ENGINE_STD_H
#define BOMBAST_ENGINE_STD_H

#define WIN32_LEAN_AND_MEAN //Exclude Rarely used stuff from Windows Headers

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

const int SCREEN_WIDTH = 800;
const int SCREEN_HEIGHT = 600;

const std::string ROOT_GAME_PATH = "../../Game/";

#include "Debugging\Logger.h"
#include "Utilities\types.h"
#include "Utilities\Math.h"
#include "Graphics3D\Geometry.h"

#ifndef BE_NEW
#if defined(_DEBUG)
	#define BE_NEW new(_NORMAL_BLOCK,__FILE__, __LINE__)
#else
	#define BE_NEW new
#endif
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

typedef D3DCOLORVALUE Color;

extern Color g_White;
extern Color g_Black;

extern const float fOPAQUE;
extern const int iOPAQUE;
extern const float fTRANSPARENT;
extern const int iTRANSPARENT;

extern INT WINAPI BombastEngine(HINSTANCE hInstance,
	HINSTANCE hPrevInstance,
	LPWSTR    lpCmdLine,
	int       nCmdShow);

#endif