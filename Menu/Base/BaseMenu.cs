using System;
using DcoderChallenge.Interface;

namespace DcoderChallenge.Base
{
    public class BaseMenu : IBaseMenu
    {
        public void ExitProgram()
        {
            throw new NotImplementedException();
        }

        public string InputCommand(string command)
        {
            switch(command.ToLower())
            {
                case "exit":
                    return "Command:EXIT";
                case "previous":
                    return "Command:GoTo";
                default:
                    return command;
            }
        }

        public bool IsMenuCommand(string command)
        {
            throw new NotImplementedException();
        }

        public void MenuCommand(string command, bool validatedCommand)
        {
            throw new NotImplementedException();
        }
    }
}