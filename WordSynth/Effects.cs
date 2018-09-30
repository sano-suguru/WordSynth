using System;
using System.Linq;
using static System.Linq.Enumerable;
using static System.String;

namespace WordSynth {
  public static class Effects {
    public static Func<string, string> Reverce() => (string words) =>
      Join(" ", words.Split(" ").Select(word => Concat(word.Reverse())));

    public static Func<string, string> Echo(int rate) => (string words) =>
      Concat(words.Select(c => c == ' '  ? c.ToString() : Concat(Repeat(c, rate))));

    public static Func<string, string> Loud(int level) => (string words) =>
      Join(" ", words.Split(" ").Select(word => word.ToUpper() + Concat(Repeat("!", level))));
  }
}
