namespace msvload.Entities
{
    public class ReadDataModel
    {
        public string Key { get; set; }
        public string Answer { get; set; }
        public string UserInput { get; set; }
        public bool IsCorrect { get; set; }

        public ReadDataModel(string Key, string Answer)
        {
            this.Key = Key;
            this.Answer = Answer;
        }

        public ReadDataModel(string key, string answer, bool isCorrect) : this(key, answer)
        {
            IsCorrect = isCorrect;
        }

        public ReadDataModel(string key, string answer, string userInput, bool isCorrect) : this(key, answer)
        {
            UserInput = userInput;
            IsCorrect = isCorrect;
        }
    }
}
