using SpeechLib;

namespace HD.PWManage.Common
{
    public class SoundHelper
    {
        private static SoundHelper _Instance = null;
        private SpeechLib.ISpeechRecoGrammar isrg;
        private SpeechLib.SpSharedRecoContextClass ssrContex = null;

        public delegate void StringEvent(string str);

        public StringEvent SetMessage;

        private SoundHelper()
        {
            ssrContex = new SpSharedRecoContextClass();
            isrg = ssrContex.CreateGrammar(1);
            SpeechLib._ISpeechRecoContextEvents_RecognitionEventHandler recHandle =
                 new _ISpeechRecoContextEvents_RecognitionEventHandler(ContexRecognition);
            ssrContex.Recognition += recHandle;
        }

        public void BeginRec()
        {
            isrg.DictationSetState(SpeechRuleState.SGDSActive);
        }

        public static SoundHelper instance()
        {
            if (_Instance == null)
                _Instance = new SoundHelper();
            return _Instance;
        }

        public void CloseRec()
        {
            isrg.DictationSetState(SpeechRuleState.SGDSInactive);
        }

        private void ContexRecognition(int iIndex, object obj, SpeechLib.SpeechRecognitionType type, SpeechLib.ISpeechRecoResult result)
        {
            if (SetMessage != null)
            {
                SetMessage(result.PhraseInfo.GetText(0, -1, true));
            }
        }
    }
}