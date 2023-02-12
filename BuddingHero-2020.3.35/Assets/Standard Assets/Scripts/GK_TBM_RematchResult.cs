using System;
using SA.Common.Models;

public class GK_TBM_RematchResult : Result
{
	public GK_TBM_RematchResult(GK_TBM_Match match)
	{
		this._Match = match;
	}

	public GK_TBM_RematchResult(string errorData) : base(new Error(errorData))
	{
	}

	public GK_TBM_Match Match
	{
		get
		{
			return this._Match;
		}
	}

	private GK_TBM_Match _Match;
}
