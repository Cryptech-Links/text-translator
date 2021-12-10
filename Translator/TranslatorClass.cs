using System;
using System.Threading.Tasks;
using GTranslate.Translators;

namespace MyTranslator
{
    internal class TranslatorClass
    {
        public static async Task<string> TranslateAsync(string TextToBeTranslated, string LangCode)
        {
            var GTranslator = new Translator();
            string translatedText = string.Empty;
            try
            {
                    var translationResult = await GTranslator.TranslateAsync(TextToBeTranslated, GTranslate.Language.GetLanguage($"{LangCode}"));
                    translatedText = translationResult.Result;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return translatedText;
        }
    }
}
