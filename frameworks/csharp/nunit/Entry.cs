// ****************************************************************
// This is free software licensed under the NUnit license. You
// may obtain a copy of the license as well as information regarding
// copyright ownership at http://nunit.org.
// ****************************************************************

using System;
using NUnit.Core;

namespace NUnit.ConsoleRunner
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Entry
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static int Main(string[] args)
		{
            return Runner.Run(args);
        }
	}
}
