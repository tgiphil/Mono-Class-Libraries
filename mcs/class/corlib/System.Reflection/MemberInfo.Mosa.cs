/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections.Generic;

namespace System.Reflection
{
	public partial class MemberInfo
	{
		public virtual int MetadataToken {
			get
			{
				throw new System.NotImplementedException();
			}
		}

	}
}
