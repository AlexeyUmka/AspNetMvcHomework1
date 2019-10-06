using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcHomework1.Domain.Core.BasicInterfaces.VoteSystem;
using AspNetMvcHomework1.Domain.Core.BasicModels.VoteSystem;

namespace AspNetMvcHomework1.Models.VoteSystem
{
    public class ElementsOfVoteSystemList
    {
        public List<ViewVote> Votes { get; set; } = new List<ViewVote>();
        public List<ViewVoter> Voters { get; set; } = new List<ViewVoter>();
        public List<ViewVoting> Votings { get; set; } = new List<ViewVoting>();
    }
    public static class ExtensionsMethodsForVotes
    { 
        public static void AddVoteFromDB(this List<ViewVote> output_votes, IEnumerable<IVote<Voter, Voting>> input_votes)
        {
            foreach (var vote in input_votes)
                output_votes.Add(new ViewVote() { VoteID = vote.VoteID, SelectedOption = vote.SelectedOption, Voter = new ViewVoter() { VoterID = vote.Voter.VoterID }, Voting = new ViewVoting() { Options = vote.Voting.Options, VotingMessage = vote.Voting.VotingMessage, VotingID = vote.Voting.VotingID } });
        }
        public static void AddVoteFromDB(this List<ViewVote> output_votes, IVote<Voter, Voting> input_vote)
        {
            output_votes.Add(new ViewVote() { VoteID = input_vote.VoteID, SelectedOption = input_vote.SelectedOption, Voter = new ViewVoter() { VoterID = input_vote.Voter.VoterID }, Voting = new ViewVoting() { Options = input_vote.Voting.Options, VotingMessage = input_vote.Voting.VotingMessage, VotingID = input_vote.Voting.VotingID } });
        }
        public static void AddVoterFromDB(this List<ViewVoter> output_voters, IEnumerable<IVoter> input_voters)
        {
            foreach (var voter in input_voters)
                output_voters.Add(new ViewVoter() { VoterID = voter.VoterID });
        }
        public static void AddVoterFromDB(this List<ViewVoter> output_voters, IVoter input_voter)
        {
            output_voters.Add(new ViewVoter() { VoterID = input_voter.VoterID});
        }
        public static void AddVotingFromDB(this List<ViewVoting> output_votings, IEnumerable<IVoting<Vote>> input_votings)
        {
            foreach (var voting in input_votings)          
                output_votings.Add(new ViewVoting() { Options = voting.Options, VotingID = voting.VotingID, VotingMessage = voting.VotingMessage });
        }
        public static void AddVotingFromDB(this List<ViewVoting> output_votings, IVoting<Vote> input_voting)
        {
            output_votings.Add(new ViewVoting() { Options = input_voting.Options, VotingID = input_voting.VotingID, VotingMessage = input_voting.VotingMessage });
        }
    }
}