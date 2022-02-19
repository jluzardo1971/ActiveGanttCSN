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

    public class ScrollEventArgs : System.EventArgs
	{
		public E_SCROLLBAR ScrollBarType;
		public int Offset;
    
		internal ScrollEventArgs()
		{
			Clear();
		}
    
		internal void Clear()
		{
			ScrollBarType = E_SCROLLBAR.SCR_VERTICAL;
			Offset = 0;
		}
	}
}