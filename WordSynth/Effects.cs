using System;
using System.Linq;

namespace WordSynth {
  public static class Effects {
    public static Func<string, string> Reverce() => (string words) =>
      string.Join(" ", words.Split(" ").Select(word => string.Concat(word.Reverse())));

    public static Func<string, string> Echo(int rate) => (string words) =>
      string.Concat(words.Select(c => c == ' '  ? c.ToString() : string.Concat(Enumerable.Repeat(c, rate))));

    public static Func<string, string> Loud(int level) => (string words) =>
      string.Join(" ", words.Split(" ").Select(word => word.ToUpper() + string.Concat(Enumerable.Repeat("!", level))));
  }
}
