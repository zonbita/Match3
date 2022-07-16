using System;
using UnityEngine;

namespace Match3
{
	[Serializable]
	public class MatchTypes : IComparable
	{
		public string name;
		public Sprite sprite;

		public int CompareTo(object obj)
		{
			if (obj == null) return 1;

			MatchTypes otherPiece = obj as MatchTypes;
			if (otherPiece != null)
				return string.Compare(this.name, otherPiece.name, StringComparison.CurrentCulture);
			else
				throw new ArgumentException("Not Match");
		}
	}
}