using System;
using GTranslate.Translators;

// Create an instance of the Google Translator
var translator = new GoogleTranslator();

// Translate any input text to english
Console.WriteLine("Ingrese su texto a traducir: ");
var textToTranslate = Console.ReadLine();
Console.WriteLine("Ingrese el idioma al que desea traducir: ");
var languageToTranslate = Console.ReadLine();
Console.WriteLine($"la palabra {textToTranslate} se traduce a {languageToTranslate} de la siguiente manera:");
var result = await translator.TranslateAsync(Convert.ToString(textToTranslate), languageToTranslate, "es");

Console.WriteLine(result);
Console.WriteLine("Presione cualquier tecla para salir");