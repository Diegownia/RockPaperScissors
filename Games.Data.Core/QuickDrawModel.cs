using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games.Data.Core.Interfaces;

namespace Games.Data.Core
{
    public class QuickDrawModel : IQuickDrawModel
    {
        public TimeSpan ReactionTime { get; set; }
        public TimeSpan RoundTime { get; set; }


    }
}
