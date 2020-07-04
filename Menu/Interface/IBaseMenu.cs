using System;

namespace DcoderChallenge.Interface
{
    interface IBaseMenu
    {
        string InputCommand(string command);
        bool IsMenuCommand(string command);
        void MenuCommand(string command, bool validatedCommand);
        void ExitProgram();
        //ToDo: Indevelopment
        //void BackToPrevious();
    }
}