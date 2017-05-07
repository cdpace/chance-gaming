using System;
using System.Collections.Generic;
using System.Text;

namespace ChanceGaming.Api.Model.Entities.Games
{
    public abstract class Game : BaseEntity<Guid>
    {
        public Game()
        {
            Id = Guid.NewGuid();
        }
    }
}
