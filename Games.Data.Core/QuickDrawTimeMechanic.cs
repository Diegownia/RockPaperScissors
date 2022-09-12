using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Games.Data.Core.Interfaces;

namespace Games.Data.Core
{
    public class QuickDrawTimeMechanic
    {
        private IQuickDrawModel _quickDrawModel;

        public QuickDrawTimeMechanic(IQuickDrawModel quickDrawModel)
        {
            quickDrawModel = _quickDrawModel;
        }
        public async void StartTimer()
        {
            await Timer();
        }

        public void DifficultySetter(int a)
        {
            switch (a)
            {
                case 1:
                    _quickDrawModel.ReactionTime = TimeSpan.FromSeconds(5);
                    _quickDrawModel.RoundTime = TimeSpan.FromSeconds(10);
                    break;
                case 2:
                    _quickDrawModel.ReactionTime = TimeSpan.FromSeconds(2.5d);
                    _quickDrawModel.RoundTime = TimeSpan.FromSeconds(5);
                    break;
                case 3:
                    _quickDrawModel.ReactionTime = TimeSpan.FromSeconds(1.5d);
                    _quickDrawModel.RoundTime = TimeSpan.FromSeconds(4);
                    break;
            }
        }

        private async Task Timer()
        {
            //var i = _quickDrawModel.ReactionTime;
            //_quickDrawModel.RoundTime = ;
            //for (_quickDrawModel.RoundTime; _quickDrawModel.RounTime < 0; )
            
        }


    }
}
