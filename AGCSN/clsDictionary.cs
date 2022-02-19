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
using System.Collections;

namespace AGCSN
{
	internal class clsDictionary : DictionaryBase
	{

		public clsDictionary()
		{
		}

		public void Add(int Value, String Key)
		{
			this.Dictionary.Add(Key, Value);
		}

		public bool Contains(string Key)
		{
			return this.Dictionary.Contains(Key);
		}

		public String StrItem(int Index)
		{
			return (String) this.Dictionary[Index];
		}

        public int this[string Key]
        {
            get { return (int)this.Dictionary[Key]; }

            set { this.Dictionary[Key] = value; }
        }
	}
}