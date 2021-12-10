// See https://aka.ms/new-console-template for more information

using MyTranslator;

Console.WriteLine("Enter text to be translated . . .");
string Content = Console.ReadLine();

Console.WriteLine("Enter language code . . .");
string LangCode = Console.ReadLine();

if (string.IsNullOrWhiteSpace(Content) || string.IsNullOrWhiteSpace(LangCode))
    return;

//if(GTranslate.Language.GetLanguage($"{LangCode}").IsServiceSupported)

var Output = await TranslatorClass.TranslateAsync(Content, LangCode.ToLower());

Console.WriteLine($"Translated Text: {Output}");