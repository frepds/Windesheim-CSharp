﻿namespace RaceSim;

public interface IParticipant : IEquipment
{
    public string Name { get; set; }
    public int Points { get; set; }
    public IEquipment Equipment { get; set; }
    public TeamColors TeamColor { get; set; }
    
}
