using System;
using System.Managment;


namespace Shutdown System
{ 
	void Shutdown
	{
		ManagmentBaseObject mboShutdown = null;
		ManagmentClass mcWin32 = new ManagmentClass("Win32_OperatingSystem");
		mcWin32.Get();

		mcWin32.Scope.Options.EnablePrivileges = true;
		ManagmentBaseObject =
			mcWin32.GetMethodParameters("Win32Shutdown");

		mboShutdownParams["Flags"]= "1";
		mboShutdownParams["Reserved"]= "0";

		foreach (ManagmentObject manObj in mcWin32.GetInstances())
		{
			mboShutdown = manObj.InvokeMethod("Win32Shutdown",
												mboShutdownParams, null);
		}	
	}
}