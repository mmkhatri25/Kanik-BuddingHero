using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class WriteClientCharacterEventRequest : PlayFabRequestCommon
	{
		public Dictionary<string, object> Body;

		public string CharacterId;

		public string EventName;

		public DateTime? Timestamp;
	}
}
