using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSynth {
  public class WordSynthesizer {
    IList<Func<string, string>> Effects { get; }

    public WordSynthesizer() =>
      Effects = new List<Func<string, string>>();

    public void AddEffect(Func<string, string> effect) => Effects.Add(effect);

    public string Play(string originalWords) =>
      Effects.Aggregate(originalWords, (words, effect) => effect.Invoke(words));
  }
}
