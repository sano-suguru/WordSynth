# WordSynth

## ラムダ式と関数合成のサンプル

プロを目指すためのRuby入門の課題をC#で実装

```cs
var echo = Effects.Echo(2);
echo.Invoke("C# is wonderful!");  //=> "CC## iiss wwoonnddeerrffull!!"

var loud = Effects.Loud(3);
loud.Invoke("C# is wonderful!");  //=>"C#!!! IS!!! WONDERFUL!!!!"

var reverse = Effects.Reverse();
reverse.Invoke("C# is wonderful!");  //=> "#C si !lufrednow"

var synth = new WordSynthesizer();
synth.AddEffect(Effects.Echo(2));
synth.AddEffect(Effects.Loud(3));
synth.AddEffect(Effects.Reverce());
synth.Play("C# is wonderful!"); //=> "!!!##CC !!!SSII !!!!!LLUUFFRREEDDNNOOWW"
```
