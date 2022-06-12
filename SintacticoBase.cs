using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProyectoFinalCompiladoresI_ISCUAA
{
    public class SintacticoBase
    {

        /// <summary>
        /// Analisa una entrada en busca de tokens validos y errores
        /// </summary>
        /// <param name="text">entrada a analizar</param>
        public IEnumerable<Token> GetTokens(string text)
        {
            if (requiereCompilar) throw new Exception("Compilación Requerida, llame al método Compile(options).");

            Match match = rex.Match(text);

            if (!match.Success) yield break;

            int line = 1, start = 0, index = 0;

            while (match.Success)
            {
                if (match.Index > index)
                {
                    string token = text.Substring(index, match.Index - index);

                    yield return new Token("ERROR", token, index, line, (index - start) + 1);

                    line += CountNewLines(token, index, ref start);
                }

                for (int i = 0; i < GNumbers.Length; i++)
                {
                    if (match.Groups[GNumbers[i]].Success)
                    {
                        string name = rex.GroupNameFromNumber(GNumbers[i]);

                        yield return new Token(name, match.Value, match.Index, line, (match.Index - start) + 1);

                        break;
                    }
                }

                line += CountNewLines(match.Value, match.Index, ref start);
                index = match.Index + match.Length;
                match = match.NextMatch();
            }

            if (text.Length > index)
            {
                yield return new Token("ERROR", text.Substring(index), index, line, (index - start) + 1);
            }


        }
    }
}