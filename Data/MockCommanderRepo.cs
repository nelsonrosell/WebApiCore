using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands= new List<Command>()
            {
                new Command{Id=0,HowTo="Boil and egg", Line="Rolled water",Platform="Kett;e and pan"},
                new Command{Id=1,HowTo="Boil and egg", Line="Rolled water",Platform="Kett;e and pan"},
                new Command{Id=3,HowTo="Boil and egg", Line="Rolled water",Platform="Kett;e and pan"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Boil and egg", Line="Rolled water",Platform="Kett;e and pan"};
        }
    }
}