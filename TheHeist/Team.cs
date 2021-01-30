using System;
using System.Collections.Generic;
using System.Text;

namespace TheHeist
{
    class Team
    {
        public List<TeamMember> group { get; set;  }
        public TeamMember teamMember { get; set; }
        public Team()
        {
            group = new List<TeamMember>();
        }

        public void addTeamMember(TeamMember teamMember)
        {
            group?.Add(teamMember);
        }

        public int? getCount()
        {
            return group?.Count;
        }
    }
}
