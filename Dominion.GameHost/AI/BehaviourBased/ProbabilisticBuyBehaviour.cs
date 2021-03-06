﻿using System;
using System.Linq;

namespace Dominion.GameHost.AI.BehaviourBased
{
    public class ProbabilisticBuyBehaviour : BuyBehaviourBase
    {
        private readonly ProbabilityDistribution _distribution;

        public ProbabilisticBuyBehaviour(ProbabilityDistribution distribution)
        {
            _distribution = distribution;
        }

        public override bool CanRespond(ActivityModel activity, GameViewModel state)
        {
            return base.CanRespond(activity, state) && 
                GetValidBuys(state).Any(c => _distribution.Contains(c.Name));
        }

        protected override CardPileViewModel SelectPile(GameViewModel state, IGameClient client)
        {
            var options = GetValidBuys(state).Where(c => _distribution.Contains(c.Name));

            var exactValueOptions = options
                .Where(pile => pile.Cost.ToString() == state.Status.AvailableSpend.DisplayValue);

            return exactValueOptions.Any() 
                ? _distribution.RandomItem(exactValueOptions, c => c.Name) 
                : _distribution.RandomItem(options, c => c.Name);
        }

        public class LearnFromGameResultBehaviour : IAIBehaviour
        {
            private readonly ProbabilityDistribution _distribution;

            public LearnFromGameResultBehaviour(ProbabilityDistribution distribution)
            {
                _distribution = distribution;
            }

           public virtual bool CanRespond(ActivityModel activity, GameViewModel state)
            {
                return state.Status.GameIsComplete;
            }

            public void Respond(IGameClient client, ActivityModel activity, GameViewModel state)
            {
                var decklist = client.GetDecklist();

                if (state.Results.Winner == client.PlayerName)
                {
                    foreach (var card in decklist.Where(c => _distribution.Contains(c.Name)))
                    {
                        _distribution.IncreaseLikelihood(card.Name);
                    }
                }
            }
        }
    }


}