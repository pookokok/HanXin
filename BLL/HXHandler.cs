using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace BLL
{
    public class HXHandler
    {
        [DllImport(@"EnCodeCS.dll", EntryPoint = "EnCsText", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public extern static int EnCsText(string szText, int iSetVersion, int iRsLevel, int iScale, int iSpace, byte[] bDMatrix, string barFile);

        [DllImport(@"EnCodeCS.dll", EntryPoint = "EnCsFile", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        public extern static int EnCsFile(string txtfile, int iSetVersion, int iRsLevel, int iScale, int iSpace, byte[] bDMatrix, string barFile);

        [DllImport(@"DeCodeCS.dll", EntryPoint = "DeCodeCsbyte", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public extern static int DeCodeCsbyte(byte[] bb, int iWidth, byte[] szInfo);
    }
}