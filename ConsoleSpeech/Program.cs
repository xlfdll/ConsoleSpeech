using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace ConsoleSpeech
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Console Speech");
            Console.WriteLine("(C) 2009 Xlfdll Workstation");

            Console.WriteLine();

            synth.Volume = 100;
            synth.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 0, CultureInfo.CurrentCulture);

            if (args.Length == 0)
            {
                Console.WriteLine("Enter below to speak:");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("> ");

                    synth.Speak(Console.ReadLine());
                }
            }
            else
            {
                foreach (String item in args)
                {
                    synth.Speak(item);
                }
            }
        }

        static SpeechSynthesizer synth = new SpeechSynthesizer();
    }
}