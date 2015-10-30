using System;

using UnityEngine;

using strange.extensions.context.api;
using strange.extensions.command.impl;

namespace strange.examples.CardGame {
	public class UpdateAIScoreCommand : Command {
		
		[Inject]
		public IHUDViewManager manager {get; set;}

		[Inject]
		public int score{ get; set; }

		public override void Execute() {
			manager.UpdateAIScore(score);
		}
		
	}
}