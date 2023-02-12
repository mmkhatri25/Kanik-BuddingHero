using System;

namespace PlayFab.PlayStreamModels
{
	public class PlayerAdEndedEventData : PlayStreamEventBase
	{
		public string AdPlacementId;

		public string AdPlacementName;

		public string AdUnit;

		public string RewardId;

		public string RewardName;

		public string TitleId;
	}
}
