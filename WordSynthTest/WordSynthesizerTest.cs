using System;
using WordSynth;
using Xunit;

namespace WordSynthTest {
  public class WordSynthesizerTest {
    [Fact]
    public void TestPlayWithManyEffect() {
      var synth = new WordSynthesizer();
      synth.AddEffect(Effects.Echo(2));
      synth.AddEffect(Effects.Loud(3));
      synth.AddEffect(Effects.Reverce());
      Assert.Equal("!!!##CC !!!SSII !!!!!LLUUFFRREEDDNNOOWW", synth.Play("C# is wonderful!"));
    }

    [Fact]
    public void TestPlayWithNoEffect() {
      var synth = new WordSynthesizer();
      Assert.Equal("C# is wonderful!", synth.Play("C# is wonderful!"));
    }
  }
}
