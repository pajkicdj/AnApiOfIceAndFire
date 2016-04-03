﻿using System.Collections.Generic;

namespace AnApiOfIceAndFire.Domain.Models
{
    public interface IOrganisation
    {
        int Identifier { get; }
        string Name { get; }
        string Description { get; }
        string Founded { get; }
        ICharacter Founder { get; }
        IReadOnlyCollection<ICharacter> KnownMembers { get; } 
    }
}