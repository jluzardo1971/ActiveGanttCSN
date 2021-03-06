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
	public abstract class clsItemBase
	{
		public String mp_sKey;
		public int mp_lIndex;

		public clsItemBase()
		{
			mp_sKey = "";
			mp_lIndex = 0;
		}

		public int Index 
		{
			get 
			{
				return mp_lIndex;
			}
			set 
			{
				mp_lIndex = value;
			}
		}
	}
}