using System;
using System.Linq;
using System.Collections.Generic;

namespace TeamworkProjects
{
    class Team
    {
        public string User { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public Team(string user, string teamName)
        {
            this.User = user;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }
        public void AddMember(string member)
        {
            Members.Add(member);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] team = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = team[0];
                string teamName = team[1];
                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(u => u.User == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(user, teamName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {user}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] argss = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = argss[0];
                string teamName = argss[1];
                Team searchedTeam = teams.FirstOrDefault(t => t.TeamName == teamName);
                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (IsAlreadyMemberInTeam(teams, memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }
                if (teams.Any(t => t.User == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchedTeam.AddMember(memberName);
            }

            List<Team> teamsWithMembers = teams.Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).ToList();
            List<Team> teamsToDisband = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName).ToList();
            PrintValidTeams(teamsWithMembers);
            PrintInvalidTeams(teamsToDisband);
        }
        static bool IsAlreadyMemberInTeam(List<Team> teams, string memberName)
        {
            foreach (Team team in teams)
            {
                if (team.Members.Contains(memberName))
                {
                    return true;
                }
            }

            return false;
        }
        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team validteam in validTeams)
            {
                Console.WriteLine(validteam.TeamName);
                Console.WriteLine($"- {validteam.User}");
                foreach (string member in validteam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
        static void PrintInvalidTeams(List<Team> teamsToDisband)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in teamsToDisband)
            {
                Console.WriteLine($"{invalidTeam.TeamName}");
            }
        }
    }
}
