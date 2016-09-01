﻿using System;
using System.Runtime.InteropServices;

namespace BombastEditor
{
    static class NativeMethods
    {
        const string BombastEditorDLLName = "BombastEditorDLL.dll";

        [DllImport(BombastEditorDLLName, CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern int EditorMain(IntPtr instancePtrAddress, IntPtr hPrevInstancePtrAddress, IntPtr hWndPtrAddress, int nCmdShow, int screenWidth, int screenHeight);
        [DllImport(BombastEditorDLLName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void RenderFrame();
        [DllImport(BombastEditorDLLName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Shutdown();
        [DllImport(BombastEditorDLLName, CallingConvention = CallingConvention.Cdecl)]
        public unsafe static extern void WndProc(IntPtr hWndPtrAddress, int msg, int wParam, int lParam);
    }
}