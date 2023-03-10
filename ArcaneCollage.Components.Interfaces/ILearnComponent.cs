using ArcaneCollage.Skills.Interfaces;
using System.Collections.Generic;

namespace ArcaneCollage.Components.Interfaces
{
    public interface ILearnComponent : IComponent
    {
        SkillType skillType { get; }
        double value { get; }

        IEnumerable<(string desc, double value)> details { get; }
    }
}
