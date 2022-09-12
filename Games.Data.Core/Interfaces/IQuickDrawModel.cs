using System;

namespace Games.Data.Core.Interfaces
{
    public interface IQuickDrawModel
    {
        TimeSpan ReactionTime { get; set; }
        TimeSpan RoundTime { get; set; }
    }
}