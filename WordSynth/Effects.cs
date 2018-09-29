using System;
using System.Linq;

namespace WordSynth {
  public static class Effects {
    public static string Reverce(string words) =>
      string.Join(" ", words.Split(" ").Select(word => string.Concat(word.Reverse())));
  }
}
