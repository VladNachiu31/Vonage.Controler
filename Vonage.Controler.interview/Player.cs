using System.Collections.Generic;
using Vonage.Controler.interview;

namespace Vonage.Controler.interview
{
    public class Player : IPlayer
    {

        public void Play(BoardCommand command)
        {
            command.Execute();
        }

        public void Play(List<BoardCommand> commands)
        {
            foreach (var boardCommand in commands)
            {
                Play(boardCommand);
            }
        }
    }
}
