﻿using System;
using System.Linq;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public sealed class Blame : IEquatable<Blame>
    {
        [DataMember(Name = "commit")]
        public BlameCommit Commit { get; set; }

        [DataMember(Name = "lines")]
        public string[] Lines { get; set; }

        public bool Equals(Blame other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Equals(Commit, other.Commit)
                && Lines is object && other.Lines is object && Lines.SequenceEqual(other.Lines, StringComparer.Ordinal);
        }

        public override bool Equals(object obj)
        {
            return obj is Blame blame && Equals(blame);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Commit != null ? Commit.GetHashCode() : 0) * 397) ^ (Lines != null ? Lines.GetHashCode() : 0);
            }
        }
    }
}
