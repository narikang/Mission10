﻿namespace Mission10.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<Team> Teams { get; }
    }
}
