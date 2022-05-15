using System.Collections.Generic;
using Vonage.Controler.interview.Commands;

namespace Vonage.Controler.interview
{
    public interface IPlayer
    {
        void Play(BoardCommand command);

        void Play(List<BoardCommand> commands);
    }
}
