using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "A", Line = "B", Platform = "C" },
                new Command { Id = 1, HowTo = "D", Line = "E", Platform = "F" },
                new Command { Id = 2, HowTo = "G", Line = "H", Platform = "I" }
             };

        return commands;

        }

    public Command GetCommandById(int Id)
        {
        return new Command { Id = 0, HowTo = "A", Line = "B", Platform = "C" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
