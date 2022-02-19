// ----------------------------------------------------------------------------------------
//                              COPYRIGHT NOTICE
// ----------------------------------------------------------------------------------------
//
// The Source Code Store LLC
// ACTIVEGANTT SCHEDULER COMPONENT FOR C# - ActiveGanttCSN
// Windows Forms Control
// Copyright (c) 2002-2017 The Source Code Store LLC
//
// All Rights Reserved. No parts of this file may be reproduced, modified or transmitted 
// in any form or by any means without the written permission of the author.
//
// ----------------------------------------------------------------------------------------
using System;

namespace AGCSN
{

	using System;
	using System.ComponentModel;
	using System.Reflection;


    public class NodeEventArgs : System.EventArgs
	{
		public int Index;
    
		internal NodeEventArgs()
		{
			Clear();
		}
    
		internal void Clear()
		{
			Index = 0;
		}
	}

}