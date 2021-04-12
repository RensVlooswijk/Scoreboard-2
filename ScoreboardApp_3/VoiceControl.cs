using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using ScoreboardApp_3;

namespace ScoreboardApp_3
{

    public class VoiceControl
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public void Voice()
        {
            SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
            //add all the available voice commands plus the voice recognition engine
            Choices commands = new Choices();
            commands.Add(new string[] { "Home", "Guest", "Player one", "Player two", "End Game", "yes I am sure", "no dont end the game", "remove point left", "remove point right", "voice help", "okey", "home set", "guest set", "yes", "no", "player one set", "player two set", "player one game", "player two game", "score", "sets", "games" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
        }

        void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            CounterPage CP = new CounterPage();
            //assign all the voice commands to specific button clicks
            switch (e.Result.Text)
            {
                case "Home":
                    CP.HomeScore.PerformClick();
                    break;
                case "Guest":
                    CP.AwayScore.PerformClick();
                    break;
                case "Player one":
                    CP.HomeScore.PerformClick();
                    break;
                case "Player two":
                    CP.AwayScore.PerformClick();
                    break;
            }
        }

        public void ButtonClickTestOn()
        {
            //recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }
        public void ButtonClickTestOff()
        {
            //recEngine.RecognizeAsyncStop();
        }

    }
}
