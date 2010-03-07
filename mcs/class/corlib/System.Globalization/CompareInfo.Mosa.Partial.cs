using System.Reflection;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Globalization.Unicode;

namespace System.Globalization
{
	public partial class CompareInfo
	{
		private void construct_compareinfo (string locale)
		{
			throw new System.NotImplementedException();
		}
		private void free_internal_collator ()
		{
			throw new System.NotImplementedException();
		}
		private int internal_compare (string str1, int offset1,
		int length1, string str2,
		int offset2, int length2,
		CompareOptions options)
		{
			throw new System.NotImplementedException();
		}
		private void assign_sortkey (object key, string source,
		CompareOptions options)
		{
			throw new System.NotImplementedException();
		}
		private int internal_index (string source, int sindex,
		int count, char value,
		CompareOptions options,
		bool first)
		{
			throw new System.NotImplementedException();
		}
		private int internal_index (string source, int sindex,
		int count, string value,
		CompareOptions options,
		bool first)
		{
			throw new System.NotImplementedException();
		}

	}
}
